using AutoMapper;
using CarsRental.Domain.Cars;

namespace CarsRental.Application.Cars
{
    public class CarMapping : Profile
    {
        public CarMapping()
        {
            CreateMap<CreateCarModel, Car>()
                .ForMember(p => p.id, _ => _.MapFrom(p => Guid.NewGuid().ToString()));

            CreateMap<Car, CreateCarModel>();

            CreateMap<Car, ReadCarModel>();

            CreateMap<UpdateCarModel, Car>();
        }
    }
}
