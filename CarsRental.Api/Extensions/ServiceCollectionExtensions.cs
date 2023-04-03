using CarsRental.Application;
using CarsRental.Infrastructure;
using CarsRental.Persistence;
using System.Text.Json.Serialization;

namespace CarsRental.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddApplicationDependencies();

            services.AddInfrastructureDependencies();

            services.AddPersistenceDependencies(configuration);

            services.AddControllers().AddJsonOptions(c =>
            {
                c.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
            services.AddSwaggerExtension();

        }
    }
}
