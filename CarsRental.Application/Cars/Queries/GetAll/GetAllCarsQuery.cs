using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Queries.GetAll
{
    public record GetAllCarsQuery : IRequest<IReadOnlyList<ReadCarModel>>;
}
