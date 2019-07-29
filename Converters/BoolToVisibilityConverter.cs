using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPFWeather.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return value is Visibility.Visible;

            return null;
        }
    }
}