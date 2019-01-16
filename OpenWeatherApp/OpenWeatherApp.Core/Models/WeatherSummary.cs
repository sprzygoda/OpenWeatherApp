using Newtonsoft.Json;
using OpenWeatherApp.API.Models;
using System.Collections.Generic;

namespace OpenWeatherApp.Core.Models
{
    public class WeatherSummary
    {
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } = new List<Weather>();

        [JsonProperty("main")]
        public Main MainWeather { get; set; } = new Main();

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;


        [JsonIgnore]
        public string Icon => $"https://openweathermap.org/img/w/{Weather[0].Icon}.png";

        [JsonIgnore]
        public string DisplayedName => $"Weather for: {Name}";

        [JsonIgnore]
        public string Main => Weather[0].Main;

        [JsonIgnore]
        public string Description => Weather[0].Description;

        [JsonIgnore]
        public string DisplayedTemperature
        {
            get
            {
                if (double.IsNaN(MainWeather.Temperature))
                {
                    return "Temperature: ";
                }
                else
                {
                    return $"Temperature: {MainWeather.Temperature}℃";
                }
            }

        }
    }
}


