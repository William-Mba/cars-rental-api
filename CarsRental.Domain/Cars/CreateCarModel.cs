using CarsRental.Domain.Enums;

namespace CarsRental.Domain.Cars
{
    public class CreateCarModel
    {
        public string Location { get; set; } = null!;

        public string ImageUri { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Model { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Cost { get; set; }

        public CostType CostType { get; set; }

    }
}
