using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace BindingProperties
{
    public class BoolToStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] styles = parameter.ToString().Split(';');
            if (targetType == typeof(Style) && value is bool)
            {
                if ((bool)value) { return GetStyle(styles[0]); }
                else { return GetStyle(styles[1]); }
            }
            else return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        Style GetStyle(string key)
        {
            return Application.Current.Resources[key] as Style;
        }
    }
}
