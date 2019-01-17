using OpenWeatherApp.Core.Models;
using OpenWeatherApp.Core.Services;
using System;
using System.Threading.Tasks;

namespace UnitTests.Mocks
{
    class OpenWeatherMockService : IOpenWeatherService
    {
        public async Task<WeatherSummary> GetWeather(string cityName)
        {
            if(cityName.Equals(TestData.TestData.CORRECT_CITY_NAME))
            {
                var result = TestData.TestData.CorrectClientResponse;

                return new WeatherSummary
                {
                    MainWeather = result.MainWeather,
                    Name = result.Name,
                    Weather = result.Weather
                };
            }
            else
            {
                throw new Exception();
            }

        }
    }
}
