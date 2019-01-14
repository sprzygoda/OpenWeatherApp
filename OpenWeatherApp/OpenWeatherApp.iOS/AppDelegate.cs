using Foundation;
using UIKit;
using MvvmCross.Platforms.Ios.Core;
using OpenWeatherApp.Core;

namespace OpenWeatherApp.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        public override UIWindow Window { get; set; }
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            base.FinishedLaunching(application, launchOptions);

            return true;
        }
    }
}