using CarsRental.Domain.Cars;
using CarsRental.Domain.Customers;
using CarsRental.Domain.Enums;

namespace CarsRental.Domain.Rentals
{
    public class Rental : BaseEntity
    {
        public Car Car { get; set; } = null!;
        public Customer Customer { get; set; } = null!;
        public decimal Price
        {
            get => Car.Cost * ((decimal)(Car.CostType == CostType.Hourly ? TotalHours : TotalDays));
            set => SetPrice(value);
        }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double TotalHours
        {
            get => (End - Start).TotalHours;
        }
        public double TotalDays
        {
            get => (End - Start).TotalDays;
        }
        public void SetPrice(decimal price)
        {
            if (price >= 1)
            {
                Price = price;
            }
        }
    }
}
