using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using OpenWeatherApp.API;
using OpenWeatherApp.Core.ViewModels;

namespace OpenWeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterType<IOpenWeatherAPIClient, OpenWeatherAPIClient>();
            RegisterAppStart<MainViewModel>();
        }
    }
}
