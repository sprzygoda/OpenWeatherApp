using OpenWeatherApp.Core.ViewModels;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.TestClasses
{
    public class MainViewModelTests
    {
        [Fact]
        public async Task Check_Weather_Command_With_Correct_City_Name_Should_Provide_Weather_Summary()
        {
            // Arrange
            var weatherService = new OpenWeatherMockService();
            var mainViewModel = new MainViewModel(weatherService)
            {
                CityName = TestData.TestData.CORRECT_CITY_NAME
            };

            // Act
            await mainViewModel.ExecuteCheckWeatherCommand();

            // Assert
            Assert.NotNull(mainViewModel.WeatherSummary);
        }

        [Fact]
        public async Task Check_Weather_Command_With_Correct_City_Name_Should_Set_Empty_Error_Message()
        {
            // Arrange
            var weatherService = new OpenWeatherMockService();
            var mainViewModel = new MainViewModel(weatherService)
            {
                CityName = TestData.TestData.CORRECT_CITY_NAME,
                ErrorMessage = "City name is empty"
            };

            // Act
            await mainViewModel.ExecuteCheckWeatherCommand();

            // Assert
            Assert.True(string.IsNullOrEmpty(mainViewModel.ErrorMessage));
        }

        [Fact]
        public async Task Check_Weather_Command_With_Incorrect_City_Name_Should_Return_COULD_NOT_FIND_Error_Message()
        {
            // Arrange
            var weatherService = new OpenWeatherMockService();
            var mainViewModel = new MainViewModel(weatherService)
            {
                CityName = TestData.TestData.INCORRECT_CITY_NAME
            };

            // Act
            await mainViewModel.ExecuteCheckWeatherCommand();

            // Assert
            Assert.StartsWith("Could not find", mainViewModel.ErrorMessage);
        }

        [Fact]
        public async Task Check_Weather_Command_With_Empty_City_Name_Should_Return_CITY_NAME_IS_EMPTY_Error_Message()
        {
            // Arrange
            var weatherService = new OpenWeatherMockService();
            var mainViewModel = new MainViewModel(weatherService)
            {
                CityName = string.Empty
            };

            // Act
            await mainViewModel.ExecuteCheckWeatherCommand();

            // Assert
            Assert.Equal("City name is empty.", mainViewModel.ErrorMessage);
        }

    }
}
