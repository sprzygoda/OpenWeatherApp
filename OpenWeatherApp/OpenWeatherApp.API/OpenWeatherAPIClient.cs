﻿using Newtonsoft.Json;
using OpenWeatherApp.API.Constants;
using OpenWeatherApp.API.Models;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace OpenWeatherApp.API
{
    public class OpenWeatherAPIClient : IOpenWeatherAPIClient
    {
        public async Task<CurrentWeather> GetOpenWeatherData(string cityName)
        {
            using (var client = new HttpClient())
            {
                var url = $"{ConnectionStrings.ApiUrl}{string.Format(ConnectionStrings.QueryParameters, cityName, "Metric", ConnectionStrings.API_KEY)}";

                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return DeserializeObject<CurrentWeather>(json, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
            }
        }
    }
}
