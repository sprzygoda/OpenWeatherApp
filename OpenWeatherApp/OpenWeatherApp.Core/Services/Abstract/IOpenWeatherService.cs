using OpenWeatherApp.Core.Models;
using System.Threading.Tasks;

namespace OpenWeatherApp.Core.Services
{
    public interface IOpenWeatherService
    {
        Task<WeatherSummary> GetWeather(string cityName);
    }
}
