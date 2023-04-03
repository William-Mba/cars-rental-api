using CarsRental.Application.Interfaces.AppSettings;
using Microsoft.Azure.Cosmos;

namespace CarsRental.Application.Interfaces
{
    public interface ICosmosDbClientFactory
    {
        public CosmosClient CosmosClient { get; }
        public ICosmosDbSettings Settings { get; }
    }
}
