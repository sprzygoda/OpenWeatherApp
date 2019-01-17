using System;
using System.Threading.Tasks;
using UnitTests.Mocks;
using UnitTests.TestData;
using Xunit;

namespace UnitTests.TestClasses
{
    public class ApiClientTests
    {
        [Theory]
        [InlineData(TestDataValues.CORRECT_CITY_NAME)]
        [InlineData(TestDataValues.INCORRECT_CITY_NAME)]
        [InlineData("")]
        public async Task Api_Client_Should_Give_Correct_Responses(string cityName)
        {
            // Arrange
            var client = new ApiClientMock();

            // Act & Assert
            if(cityName.Equals(TestDataValues.CORRECT_CITY_NAME))
            {
                var response = await client.GetOpenWeatherData(cityName);
                Assert.NotNull(response);
            }
            else
            {
                await Assert.ThrowsAnyAsync<Exception>(async () => await client.GetOpenWeatherData(cityName));
            }
        }

    }
}
