using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Commands.Update
{
    public record UpdateCarCommand(string Id, UpdateCarModel CarToUpdate) : IRequest<Car>;
}
