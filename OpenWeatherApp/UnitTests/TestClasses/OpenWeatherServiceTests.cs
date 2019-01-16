using System;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.TestClasses
{
    public class OpenWeatherServiceTests
    {
        [Fact]
        public async Task Get_Weather_With_Correct_City_Name_Should_Return_Weather_Summary()
        {
            //arrange
            var weatherService = new OpenWeatherMockService();

            //act
            var result = await weatherService.GetWeather(TestData.TestData.CORRECT_CITY_NAME);

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task Get_Weather_With_Incorrect_City_Name_Should_Throw_Exception()
        {
            //arrange
            var weatherService = new OpenWeatherMockService();
            var wrongData = TestData.TestData.INCORRECT_CITY_NAME;

            //assert
            await Assert.ThrowsAsync<Exception>(async () => await weatherService.GetWeather(wrongData));
        }

    }
}
