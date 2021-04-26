using System;
using System.Globalization;
using Xamarin.Forms;

namespace MagicGradientsApp.Controls
{
    public class StringToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = value?.ToString();
            return !string.IsNullOrEmpty(text);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
