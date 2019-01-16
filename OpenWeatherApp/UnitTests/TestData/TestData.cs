using Newtonsoft.Json;
using OpenWeatherApp.API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTests.TestData
{
    public class TestData
    {
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
        public const string CORRECT_CITY_NAME = "Rzeszow";
        public const string INCORRECT_CITY_NAME = "asdffff";

    }
}
