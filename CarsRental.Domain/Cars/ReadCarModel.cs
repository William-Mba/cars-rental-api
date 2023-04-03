using CarsRental.Domain.Enums;

namespace CarsRental.Domain.Cars
{
    public class ReadCarModel
    {
        public string Location { get; set; } = null!;
        public string ImageUri { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Cost { get; set; } = null!;
        public CostType CostType { get; set; }
    }
}
