using System;
using System.Globalization;
using System.Windows.Data;

namespace SalesDashboard
{
    public class DateTimeToNextDayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).AddDays(1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
