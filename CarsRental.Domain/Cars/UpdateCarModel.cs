using CarsRental.Domain.Enums;

namespace CarsRental.Domain.Cars
{
    public class UpdateCarModel
    {
        public string? Location { get; set; }
        public string? ImageUri { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public decimal? Cost { get; set; }
        public CostType? CostType { get; set; }

    }
}
