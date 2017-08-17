using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace BindingProperties
{
    public class NegativeNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int input = (int)value;
            if (input >= 0) return input.ToString();
            else return string.Format("({0})", 0 - input);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().StartsWith("(") && value.ToString().EndsWith(")"))
            {
                return -int.Parse(value.ToString().Substring(1, value.ToString().Length - 2));
            }
            else return value;
        }
    }
}
