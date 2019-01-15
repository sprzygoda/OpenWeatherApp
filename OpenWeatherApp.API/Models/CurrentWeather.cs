using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenWeatherApp.API.Models
{
    public class CurrentWeather
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; } = new Coord();

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } = new List<Weather>();

        [JsonProperty("base")]
        public string Base { get; set; } = string.Empty;

        [JsonProperty("main")]
        public Main MainWeather { get; set; } = new Main();

        [JsonProperty("wind")]
        public Wind Wind { get; set; } = new Wind();

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; } = new Clouds();

        [JsonProperty("sys")]
        public Sys Sys { get; set; } = new Sys();

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;


        [JsonIgnore]
        public string Icon => $"http://openweathermap.org/img/w/{Weather[0].Icon}.png";

        [JsonIgnore]
        public string DisplayedName => $"Weather for {Name}";

        [JsonIgnore]
        public string Main => Weather[0].Main;

        [JsonIgnore]
        public string Description => Weather[0].Description;

        [JsonIgnore]
        public string DisplayedTemperature => $"Temperature: {MainWeather.Temperature}℃";
    }
}
