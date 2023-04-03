using CarsRental.Application.Interfaces;
using CarsRental.Application.Interfaces.AppSettings;
using CarsRental.Persistence.AppSettings;
using CarsRental.Persistence.CosmosDb;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarsRental.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton(serviceProvider =>
            {
                var cosmosDbSettings = new CosmosDbSettings(configuration);

                CosmosClient cosmosClient = new CosmosClient(cosmosDbSettings.ConnectionString);

                Database database = cosmosClient.CreateDatabaseIfNotExistsAsync(cosmosDbSettings.DatabaseName)
                                                .GetAwaiter()
                                                .GetResult();

                database.CreateContainerIfNotExistsAsync(
                        cosmosDbSettings.CarContainerName,
                        cosmosDbSettings.CarContainerPartitionKeyPath,
                        400).GetAwaiter().GetResult();

                database.CreateContainerIfNotExistsAsync(
                        cosmosDbSettings.CarRentalContainerName,
                        cosmosDbSettings.CarRentalContainerPartitionKeyPath,
                        400).GetAwaiter().GetResult();

                database.CreateContainerIfNotExistsAsync(
                        cosmosDbSettings.EnquiryContainerName,
                        cosmosDbSettings.EnquiryContainerPartitionKeyPath,
                        400).GetAwaiter().GetResult();

                return cosmosClient;
            });

            services.AddSingleton<ICosmosDbSettings, CosmosDbSettings>();

            services.AddSingleton<ICosmosDbClientFactory, CosmosDbClientFactory>();

            return services;
        }
    }
}
