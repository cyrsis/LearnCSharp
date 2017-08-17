using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Globalization;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows;
using System.Windows.Controls;

namespace WPFComponents
{
  [ValueConversion(typeof(ListBoxItem), typeof(Thickness))]
  public class IndexToMarginConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      Thickness ret;
      int itemIndex;
      ListBoxItem lstItem;
      ListBox lstBox;

      lstItem = (value as ListBoxItem);
      lstBox = (ListBox)ItemsControl.ItemsControlFromItemContainer(lstItem);
      itemIndex = lstBox.ItemContainerGenerator.IndexFromContainer(lstItem);

      if ((itemIndex % 2) != 0)
        ret = new Thickness(5, 0, 30, 30);
      else
        ret = new Thickness(30, 25, 0, 0);

      return ret;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
