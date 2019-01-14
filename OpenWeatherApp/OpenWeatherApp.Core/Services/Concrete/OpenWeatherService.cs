using Newtonsoft.Json;
using OpenWeatherApp.Core.Models;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace OpenWeatherApp.Core.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        public async Task<WeatherSummary> GetOpenWeatherData(string cityName)
        {
            using (var client = new HttpClient())
            {
                var apiKey = "4277ea58fbf7aac972fba2bb88910bb1";
                var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=Metric&appid={apiKey}";
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return DeserializeObject<WeatherSummary>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All});
            }
        }

    }
}
