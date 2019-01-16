using Newtonsoft.Json;
using System;

namespace OpenWeatherApp.API.Models
{
    public class Sys
    {
        [JsonProperty("type")]
        public int Type { get; set; } = 0;

        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        [JsonProperty("message")]
        public string Message { get; set; } = string.Empty;

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; } = 0;

        [JsonProperty("sunset")]
        public long Sunset { get; set; } = 0;
    }
}
