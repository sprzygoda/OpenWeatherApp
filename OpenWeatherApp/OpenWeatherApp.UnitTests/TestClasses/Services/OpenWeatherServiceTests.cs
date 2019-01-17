using OpenWeatherApp.Core.Models;
using OpenWeatherApp.Core.Services;
using System.Net.Http;
using System.Threading.Tasks;
using UnitTests.Mocks;
using UnitTests.TestData;
using Xunit;

namespace UnitTests.TestClasses
{
    public class OpenWeatherServiceTests
    {
        [Fact]
        public async Task Get_Weather_With_Correct_City_Name_Should_Return_Weather_Summary()
        {
            //arrange
            var weatherService = new OpenWeatherService(new ApiClientMock(),new MappingService());

            //act
            var result = await weatherService.GetWeather(TestDataValues.CORRECT_CITY_NAME);

            //assert
            Assert.NotNull(result);
            Assert.IsType<WeatherSummary>(result);
        }

        [Fact]
        public async Task Get_Weather_With_Incorrect_City_Name_Should_Throw_HTTP_Request_Exception()
        {
            //arrange
            var weatherService = new OpenWeatherService(new ApiClientMock(), new MappingService());
            var wrongData = TestDataValues.INCORRECT_CITY_NAME;

            //assert
            await Assert.ThrowsAsync<HttpRequestException>(async () => await weatherService.GetWeather(wrongData));
        }

    }
}
