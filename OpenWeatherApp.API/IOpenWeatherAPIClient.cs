using OpenWeatherApp.API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherApp.API
{
    interface IOpenWeatherAPIClient
    {
        Task<CurrentWeather> GetOpenWeatherData(string cityName);
    }
}
