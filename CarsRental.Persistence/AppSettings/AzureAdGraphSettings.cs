namespace CarsRental.Persistence.AppSettings
{
    public class AzureAdGraphSettings
    {
        public string AzureAdB2CTenant { get; set; } = null!;
        public string PolicyName { get; set; } = null!;
        public string ClientId { get; set; } = null!;
        public string ClientSecret { get; set; } = null!;
        public string ApiUrl { get; set; } = null!;
        public string ApiVersion { get; set; } = null!;
        public string ExtensionsAppClientId { get; set; } = null!;
    }
}
