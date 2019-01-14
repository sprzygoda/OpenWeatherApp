using Newtonsoft.Json;

namespace OpenWeatherApp.Core.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; } = 0;

        [JsonProperty("pressure")]
        public double Pressure { get; set; } = 0;

        [JsonProperty("humidity")]
        public double Humidity { get; set; } = 0;

        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; } = 0;

        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; } = 0;
    }
}