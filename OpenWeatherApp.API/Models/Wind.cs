using Newtonsoft.Json;

namespace OpenWeatherApp.API.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; } = 0;

        [JsonProperty("deg")]
        public double Degrees { get; set; } = 0;
    }
}
