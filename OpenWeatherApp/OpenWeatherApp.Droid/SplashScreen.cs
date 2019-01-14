using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
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