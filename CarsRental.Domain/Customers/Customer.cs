using CarsRental.Domain.Cars;

namespace CarsRental.Domain.Customers
{
    public class Customer : BaseEntity
    {
        public string Location { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobilePhone { get; set; } = null!;
        public Car? Car { get; set; }
    }
}
