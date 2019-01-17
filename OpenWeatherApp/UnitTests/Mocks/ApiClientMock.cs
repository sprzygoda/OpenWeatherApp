using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenWeatherApp.API;
using OpenWeatherApp.API.Models;
using static Newtonsoft.Json.JsonConvert;

namespace UnitTests.Mocks
{
    public class ApiClientMock : IOpenWeatherAPIClient
    {
        public async Task<CurrentWeather> GetOpenWeatherData(string cityName)
        {
            try
            {
                using (var client = new HttpClient(new HttpMessageHandlerMock()) { BaseAddress = new Uri( "http://api.test.com")})
                {
                    client.DefaultRequestHeaders.Add(cityName, "testCity");

                    var json = await  client.GetStringAsync(client.BaseAddress);

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
