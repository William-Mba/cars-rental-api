namespace CarsRental.Persistence.AppSettings
{
    public class AzureAdB2CSettings
    {
        public const string SectionName = "AzureAdB2C";
        public string Tenant { get; set; } = null!;
        public string ClientId { get; set; } = null!;
        public string Policy { get; set; } = null!;
    }
}
