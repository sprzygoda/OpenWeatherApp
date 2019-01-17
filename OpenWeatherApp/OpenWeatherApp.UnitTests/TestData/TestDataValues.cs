using Newtonsoft.Json;
using OpenWeatherApp.API.Models;
using System;
using System.IO;

namespace UnitTests.TestData
{
    public static class TestDataValues
    {
        public const string CORRECT_CITY_NAME = "Rzeszow";
        public const string INCORRECT_CITY_NAME = "asdffff";
        public static CurrentWeather CorrectClientResponse
        {
            get
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../TestData/TestWeatherData.json");
                StreamReader reader = new StreamReader(path);
                var json = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<CurrentWeather>(json);
            }
        }

    }
}
