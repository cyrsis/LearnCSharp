using System;
using System.Windows.Data;
using System.Windows.Media;

namespace ExecutiveDashboard
{
    public class HSLtoRGBConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color color = ColorConverter.HSLtoRGB(1 - (double)value, 1, 1);
            return color;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
