// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Blank.Views
{
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton checkWeatherButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField cityNameEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel descriptionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel errorLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView iconImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel temperatureLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel weatherForLabel { get; set; }

        [Action ("CheckWeatherButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CheckWeatherButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (checkWeatherButton != null) {
                checkWeatherButton.Dispose ();
                checkWeatherButton = null;
            }

            if (cityNameEntry != null) {
                cityNameEntry.Dispose ();
                cityNameEntry = null;
            }

            if (descriptionLabel != null) {
                descriptionLabel.Dispose ();
                descriptionLabel = null;
            }

            if (errorLabel != null) {
                errorLabel.Dispose ();
                errorLabel = null;
            }

            if (iconImage != null) {
                iconImage.Dispose ();
                iconImage = null;
            }

            if (temperatureLabel != null) {
                temperatureLabel.Dispose ();
                temperatureLabel = null;
            }

            if (weatherForLabel != null) {
                weatherForLabel.Dispose ();
                weatherForLabel = null;
            }
        }
    }
}