using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Data;

namespace WPFComponents
{
  [ValueConversion(typeof(Product), typeof(string))]
  public class ProductObjectConverter : IValueConverter
  {
    public object Convert(object value, Type targetType,
                                    object parameter, CultureInfo culture)
    {
      Product prod;
      string ret = string.Empty;

      prod = (Product)value;
      if(prod != null)
        ret = prod.ProductName + "  (ProductId=" + prod.ProductId.ToString() + ")";

      return ret;
    }

    public object ConvertBack(object value, Type targetType,
                                                object parameter, CultureInfo culture)
    {
      return System.Convert.ToString(value);
    }
  }
}
