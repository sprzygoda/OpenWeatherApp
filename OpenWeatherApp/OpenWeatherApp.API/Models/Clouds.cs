using Newtonsoft.Json;

namespace OpenWeatherApp.API.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; } = 0;
    }
}