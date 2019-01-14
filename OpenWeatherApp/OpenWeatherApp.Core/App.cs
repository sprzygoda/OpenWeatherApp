using MvvmCross;
using MvvmCross.ViewModels;
using OpenWeatherApp.Core.Services;
using OpenWeatherApp.Core.ViewModels;

namespace OpenWeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<IOpenWeatherService, OpenWeatherService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}
