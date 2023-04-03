using AutoMapper;
using CarsRental.Domain.Cars;
using MediatR;

namespace CarsRental.Application.Cars.Commands.Update
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, Car>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public UpdateCarCommandHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<Car> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var car = _mapper.Map<Car>(request.CarToUpdate);
            car.id = request.Id;

            var updatedCar = await _carRepository.UpdateAsync(car);

            return updatedCar;
        }
    }
}