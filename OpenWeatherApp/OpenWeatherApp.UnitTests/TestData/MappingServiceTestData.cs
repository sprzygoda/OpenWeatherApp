using OpenWeatherApp.API.Models;
using System.Collections.Generic;

namespace OpenWeatherApp.UnitTests.TestData
{
    public class MappingServiceTestData
    {
        public static IEnumerable<object[]> WeatherModels => new List<object[]>
        {
            new CurrentWeather[]{new CurrentWeather()},
            new CurrentWeather[]
            {
                new CurrentWeather()
                {
                    Base = "",
                    Name = "name 1",
                }
            },
            new CurrentWeather[]
            {
                new CurrentWeather()
                {
                    Base = "",
                    Name = "name 1",
                    MainWeather = new Main() { Humidity=0f, MaxTemperature = -1f, MinTemperature = -3f },
                    Clouds = new Clouds() { All = 2 },
                    Coord = new Coord(){ },
                    Sys = new Sys(){ },
                    Weather = new List<Weather>()
                    {
                        new Weather(),
                        new Weather(),
                        new Weather(),
                        new Weather()
                    }
                }
            },
            new CurrentWeather[]
            {
                new CurrentWeather()
                {
                    Base = "",
                    Name = "name 1",
                    MainWeather = new Main() { },
                    Clouds = new Clouds() { },
                    Coord = new Coord(){ },
                    Sys = new Sys(){ },
                    Weather = new List<Weather>()
                }
            },
            new CurrentWeather[]
            {
                new CurrentWeather()
                {
                    Base = "",
                    Name = "name 1",
                    MainWeather = new Main() { },
                    Clouds = new Clouds() { },
                    Coord = new Coord(){ },
                    Sys = new Sys(){ },
                    Weather = new List<Weather>()
                    {
                        new Weather()
                        {
                            Description = "cloudy",
                            Icon = "d01",
                            Id = 111,
                            Main = "Cloudy"
                        },
                        new Weather()
                        {
                            Description = "more than cloudy",
                            Icon = "d03",
                            Id = 132,
                            Main = "Heavy clouds"
                        }
                    }
                }
            }
        };
   }
}
