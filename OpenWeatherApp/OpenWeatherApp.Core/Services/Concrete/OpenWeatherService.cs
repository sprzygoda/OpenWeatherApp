using OpenWeatherApp.API;
using OpenWeatherApp.Core.Models;
using System.Threading.Tasks;


namespace OpenWeatherApp.Core.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        readonly IOpenWeatherAPIClient _openWeatherAPIClient;
        readonly IMappingService _mappingService;
        public OpenWeatherService(IOpenWeatherAPIClient openWeatherAPIClient, IMappingService mappingService)
        {
            _openWeatherAPIClient = openWeatherAPIClient;
            _mappingService = mappingService;
        }

        public async Task<WeatherSummary> GetWeather(string cityName)
        {
            var result = await _openWeatherAPIClient.GetOpenWeatherData(cityName);

            return _mappingService.CurrentWeatherToWeatherSummary(result);
        }
    }
}
