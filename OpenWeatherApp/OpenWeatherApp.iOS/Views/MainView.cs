using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using OpenWeatherApp.Core.ViewModels;
using OpenWeatherApp.iOS.Converters;
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
            set.Bind(descriptionLabel).To(vm => vm.WeatherSummary.Description);
            set.Bind(temperatureLabel).To(vm => vm.WeatherSummary.DisplayedTemperature);
            set.Bind(checkWeatherButton).To(vm => vm.CheckWeatherCommand);
            set.Bind(weatherForLabel).To(vm => vm.WeatherSummary.DisplayedName);
            set.Bind(iconImage).To(vm => vm.WeatherSummary.Icon).WithConversion(new UrlToImageConverter());
            set.Bind(errorLabel).To(vm => vm.ErrorMessage);

            set.Apply();

            cityNameEntry.ShouldReturn = (textField) => {
                cityNameEntry.ResignFirstResponder();
                return true;
            };

            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                cityNameEntry.ResignFirstResponder();
            }));


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

        partial void CheckWeatherButton_TouchUpInside(UIButton sender)
        {
            cityNameEntry.ResignFirstResponder();
        }


        #endregion
    }
}