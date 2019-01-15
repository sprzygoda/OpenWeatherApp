using Newtonsoft.Json;
using OpenWeatherApp.API.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace OpenWeatherApp.API
{
    public class OpenWeatherAPIClient : IOpenWeatherAPIClient
    {
        public async Task<CurrentWeather> GetOpenWeatherData(string cityName)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var apiKey = "4277ea58fbf7aac972fba2bb88910bb1";
                    var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=Metric&appid={apiKey}";
                    var json = await client.GetStringAsync(url);

                    if (string.IsNullOrWhiteSpace(json))
                        return null;

                    return DeserializeObject<CurrentWeather>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
