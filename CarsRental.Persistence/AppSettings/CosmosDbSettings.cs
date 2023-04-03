using CarsRental.Application.Interfaces.AppSettings;
using Microsoft.Extensions.Configuration;

namespace CarsRental.Persistence.AppSettings
{
    public class CosmosDbSettings : ICosmosDbSettings
    {
        private readonly IConfiguration _configuration;

        public CosmosDbSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string ConnectionString => _configuration.GetSection("CosmosDb:ConnectionString").Value!;
        public string DatabaseName => _configuration.GetSection("CosmosDb:DatabaseName").Value!;
        public string CarContainerName => _configuration.GetSection("CosmosDb:CarContainerName").Value!;
        public string CarContainerPartitionKeyPath => _configuration.GetSection("CosmosDb:CarContainerPartitionKeyPath").Value!;
        public string EnquiryContainerName => _configuration.GetSection("CosmosDb:EnquiryContainerName").Value!;
        public string EnquiryContainerPartitionKeyPath => _configuration.GetSection("CosmosDb:EnquiryContainerPartitionKeyPath").Value!;
        public string CarRentalContainerName => _configuration.GetSection("CosmosDb:CarRentalContainerName").Value!;
        public string CarRentalContainerPartitionKeyPath => _configuration.GetSection("CosmosDb:CarRentalContainerPartitionKeyPath").Value!;
    }
}
