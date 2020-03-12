namespace webapi.Services
{
    public class WeatherDatabaseSettings : IWeatherDatabaseSettings
    {
        public string WeatherCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}