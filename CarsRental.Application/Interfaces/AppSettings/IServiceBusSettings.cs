namespace CarsRental.Application.Interfaces.AppSettings
{
    public interface IServiceBusSettings
    {
        string ConnectionString { get; set; }
        string QueueName { get; set; }
    }
}
