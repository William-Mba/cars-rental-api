using CarsRental.Application.Interfaces;
using CarsRental.Application.Interfaces.AppSettings;
using Microsoft.Azure.Cosmos;

namespace CarsRental.Persistence.CosmosDb
{
    public class CosmosDbClientFactory : ICosmosDbClientFactory
    {
        private readonly CosmosClient _cosmosClient;
        private readonly ICosmosDbSettings _cosmosDbSettings;
        public CosmosDbClientFactory(CosmosClient cosmosClient, ICosmosDbSettings cosmosDbSettings)
        {
            _cosmosClient = cosmosClient;
            _cosmosDbSettings = cosmosDbSettings;
        }

        public CosmosClient CosmosClient => _cosmosClient;

        public ICosmosDbSettings Settings => _cosmosDbSettings;
    }
}
