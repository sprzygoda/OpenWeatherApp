using OpenWeatherApp.API.Models;
using OpenWeatherApp.Core.Models;

namespace OpenWeatherApp.Core.Services
{
    public interface IMappingService
    {
        WeatherSummary CurrentWeatherToWeatherSummary(CurrentWeather weather);
    }
}
