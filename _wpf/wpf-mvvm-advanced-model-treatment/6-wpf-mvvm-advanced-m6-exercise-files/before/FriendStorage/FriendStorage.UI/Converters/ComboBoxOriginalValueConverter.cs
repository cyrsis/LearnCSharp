using FriendStorage.UI.DataProvider.Lookups;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace FriendStorage.UI.Converters
{
  public class ComboBoxOriginalValueConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      var id = (int)value;
      var comboBox = parameter as ComboBox;
      if(comboBox!=null && comboBox.ItemsSource != null)
      {
        var lookupItem 
          = comboBox.ItemsSource.OfType<LookupItem>().SingleOrDefault(l => l.Id == id);
        if(lookupItem!= null)
        {
          return lookupItem.DisplayValue;
        }
      }
      return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
