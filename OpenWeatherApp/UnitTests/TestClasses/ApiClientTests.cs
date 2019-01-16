using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.TestClasses
{
    public class ApiClientTests
    {
        [Theory]
        [InlineData(TestData.TestData.CORRECT_CITY_NAME)]
        [InlineData(TestData.TestData.INCORRECT_CITY_NAME)]
        [InlineData("")]
        public async Task Api_Client_Should_Give_Correct_Response(string cityName)
        {
            // Arrange
            var client = new ApiClientMock();

            // Assert
            if(cityName.Equals(TestData.TestData.CORRECT_CITY_NAME))
            {
                var response = await client.GetOpenWeatherData(cityName);
                Assert.NotNull(response);
            }
            else
            {
                await Assert.ThrowsAnyAsync<Exception>(async () => { await client.GetOpenWeatherData(cityName); });
            }
        }

    }
}
