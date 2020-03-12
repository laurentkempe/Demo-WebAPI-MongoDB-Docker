using System.Collections.Generic;

namespace webapi.Services
{
    public interface IWeatherService
    {
        WeatherForecast Create(WeatherForecast weatherForecast);
        IEnumerable<WeatherForecast> Create(IEnumerable<WeatherForecast> weatherForecasts);
        List<WeatherForecast> Get();
        void Clean();
    }
}