namespace CarsRental.Application.Interfaces.AppSettings
{
    public interface ICosmosDbSettings
    {
        string ConnectionString { get; }
        string DatabaseName { get; }
        string CarContainerName { get; }
        string CarContainerPartitionKeyPath { get; }
        string EnquiryContainerName { get; }
        string EnquiryContainerPartitionKeyPath { get; }
        string CarRentalContainerName { get; }
        string CarRentalContainerPartitionKeyPath { get; }
    }
}
