using OpenWeatherApp.API.Models;
using OpenWeatherApp.Core.Models;
using OpenWeatherApp.Core.Services;
using OpenWeatherApp.UnitTests.TestData;
using Xunit;

namespace UnitTests.TestClasses
{
    public class MappingServiceTests
    {
        [Theory]
        [MemberData(nameof(MappingServiceTestData.WeatherModels), MemberType = typeof(MappingServiceTestData))]
        public void Mapping_Service_Should_Return_Not_Null_Weather_Summary(CurrentWeather weather)
        {
            // Act
            var summary = new MappingService().CurrentWeatherToWeatherSummary(weather);

            // Assert
            Assert.IsType<WeatherSummary>(summary);
            Assert.NotNull(summary);
        }
    }
}
