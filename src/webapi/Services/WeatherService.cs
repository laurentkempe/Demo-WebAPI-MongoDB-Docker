using System.Collections.Generic;
using MongoDB.Driver;
using webapi.Services;

namespace webapi.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IMongoCollection<WeatherForecast> _weatherForecasts;

        public WeatherService(IWeatherDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _weatherForecasts = database.GetCollection<WeatherForecast>(settings.WeatherCollectionName);
        }

        public List<WeatherForecast> Get() =>
                _weatherForecasts.Find(weatherForecast => true).ToList();

        public WeatherForecast Create(WeatherForecast weatherForecast)
        {
            _weatherForecasts.InsertOne(weatherForecast);

            return weatherForecast;
        }

        public IEnumerable<WeatherForecast> Create(IEnumerable<WeatherForecast> weatherForecasts)
        {
            _weatherForecasts.InsertMany(weatherForecasts);

            return weatherForecasts;
        }

        public void Clean()
        {
            _weatherForecasts.DeleteMany(weatherForecast => true);
        }
    }
}