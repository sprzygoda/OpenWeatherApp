using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Foundation;
using MvvmCross.Converters;
using UIKit;

namespace OpenWeatherApp.iOS.Converters
{
    class UrlToImageConverter : IMvxValueConverter
    {
       public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using (var url = new NSUrl((string) value))
            using (var data = NSData.FromUrl(url))
                return UIImage.LoadFromData(data);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}