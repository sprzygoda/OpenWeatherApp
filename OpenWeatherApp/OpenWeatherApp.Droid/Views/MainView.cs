
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
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
        public override bool OnTouchEvent(MotionEvent e)
        {
            InputMethodManager imm = (InputMethodManager)GetSystemService(InputMethodService);
            imm.HideSoftInputFromWindow(FindViewById(Resource.Id.textView1).WindowToken, 0);
            return base.OnTouchEvent(e);
        }
    }
}