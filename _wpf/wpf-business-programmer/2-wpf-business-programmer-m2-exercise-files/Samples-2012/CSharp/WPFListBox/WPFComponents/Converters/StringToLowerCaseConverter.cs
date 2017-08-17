using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace WPFComponents
{
  [ValueConversion(typeof(string), typeof(string))]
  public class StringToLowerCaseConverter : IValueConverter
  {
    public object Convert(object value, Type targetType,
                                    object parameter, CultureInfo culture)
    {
      return System.Convert.ToString(value).ToLower();
    }

    public object ConvertBack(object value, Type targetType,
                                                object parameter, CultureInfo culture)
    {
      return System.Convert.ToString(value);
    }
  }
}
