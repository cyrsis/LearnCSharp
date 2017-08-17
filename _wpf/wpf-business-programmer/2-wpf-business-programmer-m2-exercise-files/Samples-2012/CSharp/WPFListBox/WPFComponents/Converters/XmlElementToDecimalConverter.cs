using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;
using System.Xml;

namespace WPFComponents
{
  [ValueConversion(typeof(XmlElement), typeof(decimal))]
  public class XmlElementToDecimalConverter : IValueConverter
  {
    public object Convert(object value, Type targetType,
                                        object parameter, CultureInfo culture)
    {
      return System.Convert.ToDecimal(((XmlElement)value).InnerText);
    }

    public object ConvertBack(object value, Type targetType, 
                                                object parameter, CultureInfo culture)
    {
      return System.Convert.ToString(value);
    }
  }
}