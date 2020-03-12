namespace webapi.Services
{
    public interface IWeatherDatabaseSettings
    {
        string WeatherCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}