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
  [ValueConversion(typeof(ListBoxItem), typeof(decimal))]
  public class IndexToAngleConverter : IValueConverter
  {
    public const int ANGLE = 15;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      double ret;
      int itemIndex;
      ListBoxItem lstItem;
      ListBox lstBox;

      // The 'value' parameter is the ListBoxItem
      lstItem = (value as ListBoxItem);
      // Get a reference to the list box so we can get the index of which item is being drawn
      lstBox = (ListBox)ItemsControl.ItemsControlFromItemContainer(lstItem);
      // Get the index of the item being drawn
      itemIndex = lstBox.ItemContainerGenerator.IndexFromContainer(lstItem);

      if ((itemIndex % 2) != 0)
        ret = ANGLE;
      else
        ret = -(ANGLE);

      return ret;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
