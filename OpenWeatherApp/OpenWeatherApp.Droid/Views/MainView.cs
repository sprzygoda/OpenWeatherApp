﻿
using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using OpenWeatherApp.Core.ViewModels;

namespace OpenWeatherApp.Droid.Views
{
    [Activity(
        Label = "Open Weather App", 
        Icon = "@drawable/icon",
        Theme = "@style/AppTheme")]
    public class MainView : MvxActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
            
        }
    }
}