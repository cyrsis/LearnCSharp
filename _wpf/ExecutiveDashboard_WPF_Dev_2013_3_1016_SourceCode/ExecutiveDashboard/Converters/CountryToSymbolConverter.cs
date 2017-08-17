using System;
using System.Globalization;
using System.Windows.Data;

namespace ExecutiveDashboard
{
    public class CountryToSymbolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Germany": return 'f';
                case "United States": return 'U';
                case "Canada": return 'c';
                case "United Kingdom": return '*';
                case "Australia": return 's';
                case "France": return 'w';
            }
            return ((DateTime)value).AddDays(1);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
