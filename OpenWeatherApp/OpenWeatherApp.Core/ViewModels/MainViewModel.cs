using MvvmCross.Commands;
using MvvmCross.ViewModels;
using OpenWeatherApp.Core.Models;
using OpenWeatherApp.Core.Services;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OpenWeatherApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        readonly IOpenWeatherService _openWeatherService;

        private ICommand _checkWeatherCommand;
        public ICommand CheckWeatherCommand
        {
            get
            {
                _checkWeatherCommand = _checkWeatherCommand ?? new MvxAsyncCommand(async () => 
                {
                    await ExecuteCheckWeatherCommand();
                });
                return _checkWeatherCommand;
            }
        }


        private string _cityName;
        public string CityName
        {
            get => _cityName;
            set
            {
                SetProperty(ref _cityName, value);
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                SetProperty(ref _errorMessage, value);
            }
        }

        private WeatherSummary _weatherSummary = new WeatherSummary();
        public WeatherSummary WeatherSummary
        {
            get => _weatherSummary;
            set
            {
                SetProperty(ref _weatherSummary, value);
            }
        }

        public MainViewModel(IOpenWeatherService openWeatherService)
        {
            _openWeatherService = openWeatherService;
        }

        public async Task ExecuteCheckWeatherCommand()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CityName))
                {
                    ErrorMessage = $"City name is empty.";
                    return;
                }
                WeatherSummary = await _openWeatherService.GetWeather(CityName);
                ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                ErrorMessage = $"Could not find {CityName}";
                return;
            }
        }
    }
}
