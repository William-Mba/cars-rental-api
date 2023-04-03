using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Queries.GetById
{
    public record GetCarByIdQuery(string CarId) : IRequest<ReadCarModel>;
}
