using CarsRental.Application.Cars;
using CarsRental.Application.Interfaces;
using CarsRental.Application.Services;
using CarsRental.Domain.Cars;

namespace CarsRental.Infrastructure.Cars
{
    public class CarRepository : CosmosDbService<Car>, ICarRepository
    {
        public override string ContainerName => _cosmosDbClientFactory.Settings.CarContainerName;

        public CarRepository(ICosmosDbClientFactory cosmosDbClientFactory) : base(cosmosDbClientFactory)
        {
        }

    }
}
