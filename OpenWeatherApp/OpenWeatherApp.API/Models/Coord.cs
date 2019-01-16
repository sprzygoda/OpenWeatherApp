using Newtonsoft.Json;

namespace OpenWeatherApp.API.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; } = 0;

        [JsonProperty("lat")]
        public double Latitude { get; set; } = 0;
    }
}
