using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Commands.Create
{
    public record CreateCarCommand(CreateCarModel CarToCreate) : IRequest<Car>;
}
