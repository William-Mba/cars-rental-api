using CarsRental.Application.Interfaces;
using CarsRental.Domain.Cars;

namespace CarsRental.Application.Cars
{
    public interface ICarRepository : IAsyncRepository<Car>
    {
    }
}
