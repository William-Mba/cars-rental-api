using AutoMapper;
using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Queries.GetAll
{
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IReadOnlyList<ReadCarModel>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public GetAllCarsQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<IReadOnlyList<ReadCarModel>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            var cars = await _carRepository.GetAllAsync();

            var readOnlyCars = _mapper.Map<IReadOnlyList<ReadCarModel>>(cars);

            return readOnlyCars;
        }
    }
}
