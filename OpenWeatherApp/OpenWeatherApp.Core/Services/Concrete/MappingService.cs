using OpenWeatherApp.API.Models;
using OpenWeatherApp.Core.Models;
using System;

namespace OpenWeatherApp.Core.Services
{
    public class MappingService : IMappingService
    {
        public WeatherSummary CurrentWeatherToWeatherSummary(CurrentWeather weather)
        {
            return new WeatherSummary
            {
                MainWeather = weather.MainWeather,
                Name = weather.Name,
                Weather = weather.Weather
            };
        }
    }
}
