namespace CarsRental.Application.Interfaces.AppSettings
{
    public interface IBlobStorageSettings
    {
        string ContainerName { get; set; }
        string ConnectionString { get; set; }
        string Key { get; set; }
        string AccountName { get; set; }
    }
}
