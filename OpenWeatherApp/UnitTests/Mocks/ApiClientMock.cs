using System;
using System.Net.Http;
using System.Net.Http.Headers;
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
            //TODO
            
        }
    }
}
