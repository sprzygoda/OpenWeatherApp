using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenWeatherApp.Core.Models
{
    public class WeatherSummary
    {
        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } = new List<Weather>();

        [JsonProperty("main")]
        public Main MainWeather { get; set; } = new Main();

        [JsonIgnore]
        public string Icon =>  $"http://openweathermap.org/img/w/{Weather[0].Icon}.png";
    }
}
