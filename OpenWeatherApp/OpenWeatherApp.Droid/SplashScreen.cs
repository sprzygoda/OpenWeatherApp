using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;

namespace OpenWeatherApp.Droid
{
    [Activity(
        MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]

    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
                : base(Resource.Layout.SplashScreen)
        {
        }
    }
}