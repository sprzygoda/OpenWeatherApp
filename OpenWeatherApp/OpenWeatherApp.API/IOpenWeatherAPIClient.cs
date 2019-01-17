using OpenWeatherApp.API.Models;
using System.Threading.Tasks;

namespace OpenWeatherApp.API
{
    public interface IOpenWeatherAPIClient
    {
        Task<CurrentWeather> GetOpenWeatherData(string cityName);
    }
}
