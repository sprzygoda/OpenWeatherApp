using OpenWeatherApp.API;
using OpenWeatherApp.Core.Models;
using System.Threading.Tasks;


namespace OpenWeatherApp.Core.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        readonly IOpenWeatherAPIClient _openWeatherAPIClient;
        public OpenWeatherService(IOpenWeatherAPIClient openWeatherAPIClient)
        {
            _openWeatherAPIClient = openWeatherAPIClient;
        }

        public async Task<WeatherSummary> GetWeather(string cityName)
        {
            var result = await _openWeatherAPIClient.GetOpenWeatherData(cityName);

            return new WeatherSummary
            {
                MainWeather = result.MainWeather,
                Name = result.Name,
                Weather = result.Weather
            };
        }
    }
}
