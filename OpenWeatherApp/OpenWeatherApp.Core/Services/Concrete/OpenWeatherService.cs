using OpenWeatherApp.API;
using OpenWeatherApp.Core.Models;
using System.Threading.Tasks;


namespace OpenWeatherApp.Core.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        public async Task<WeatherSummary> GetWeather(string cityName)
        {
            OpenWeatherAPIClient client = new OpenWeatherAPIClient();
            var result = await client.GetOpenWeatherData(cityName);

            return new WeatherSummary
            {
                MainWeather = result.MainWeather,
                Name = result.Name,
                Weather = result.Weather
            };
        }
    }
}
