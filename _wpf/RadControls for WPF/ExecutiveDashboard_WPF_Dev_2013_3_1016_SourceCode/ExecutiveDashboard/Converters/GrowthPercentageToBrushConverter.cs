using System;
using System.Globalization;
using System.Windows.Data;

namespace ExecutiveDashboard
{
    public class GrowthPercentageToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double growthPercentage = System.Convert.ToDouble(value);

            var result = growthPercentage > 0 ? App.Current.Resources["over"] : growthPercentage < 0 ? App.Current.Resources["under"] : null; 
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
