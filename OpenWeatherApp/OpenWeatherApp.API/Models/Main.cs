using Newtonsoft.Json;

namespace OpenWeatherApp.API.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; } = double.NaN;

        [JsonProperty("pressure")]
        public double Pressure { get; set; } = double.NaN;

        [JsonProperty("humidity")]
        public double Humidity { get; set; } = double.NaN;

        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; } = double.NaN;

        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; } = double.NaN;
    }
}