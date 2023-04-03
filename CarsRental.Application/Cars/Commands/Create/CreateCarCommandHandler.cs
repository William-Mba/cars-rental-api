using AutoMapper;
using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Commands.Create
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Car>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CreateCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<Car> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = _mapper.Map<Car>(request.CarToCreate);

            var createdCar = await _carRepository.AddAsync(car);

            return createdCar;
        }
    }
}
