using System;
using System.Globalization;
using System.Windows.Data;

namespace SalesDashboard
{
    public class GrowthPercentageToScaleTransformConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal growthPercentage = (decimal)value;

            var result = growthPercentage > 0 ? -1 : growthPercentage < 0 ? 1 : 0; 
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
