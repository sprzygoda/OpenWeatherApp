using MvvmCross.Commands;
using MvvmCross.ViewModels;
using OpenWeatherApp.Core.Models;
using OpenWeatherApp.Core.Services;
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
                    WeatherSummary = await _openWeatherService.GetOpenWeatherData(CityName);
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

        private WeatherSummary _weatherSummary;
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

    }
}
