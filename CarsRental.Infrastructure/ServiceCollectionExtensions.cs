using CarsRental.Application.Cars;
using CarsRental.Infrastructure.Cars;
using Microsoft.Extensions.DependencyInjection;

namespace CarsRental.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {

            services.AddSingleton<ICarRepository, CarRepository>();

            return services;
        }
    }
}
