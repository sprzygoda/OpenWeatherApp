using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using OpenWeatherApp.Core.ViewModels;
using UIKit;

namespace Blank.Views
{
    [MvxFromStoryboard]
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        { 
            base.DidReceiveMemoryWarning();
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<MainView, MainViewModel>();

            set.Bind(cityNameEntry).To(vm => vm.CityName);
            set.Bind(weatherDataLabel).To(vm => vm.WeatherSummary.Weather[0].Description);
            set.Bind(checkWeatherButton).To(vm => vm.CheckWeatherCommand);

            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }


        #endregion
    }
}