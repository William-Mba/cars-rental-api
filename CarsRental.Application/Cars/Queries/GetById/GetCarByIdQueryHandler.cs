using AutoMapper;
using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Queries.GetById
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, ReadCarModel>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetCarByIdQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<ReadCarModel> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var car = await _carRepository.GetByIdAsync(request.CarId);
            var carToRead = _mapper.Map<ReadCarModel>(car);
            return carToRead;
        }
    }
}
