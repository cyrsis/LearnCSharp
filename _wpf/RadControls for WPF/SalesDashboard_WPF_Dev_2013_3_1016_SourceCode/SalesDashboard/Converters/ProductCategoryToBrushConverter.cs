using System;
using System.Globalization;
using System.Windows.Data;

namespace SalesDashboard
{
    public class ProductCategoryToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string productCategory = value.ToString().ToLower();

            switch (productCategory)
            {
                case "bikes": return App.Current.Resources["bikes"];
                case "components": return App.Current.Resources["components"];
                case "clothing": return App.Current.Resources["clothing"];
                case "accessories": return App.Current.Resources["accessories"]; 
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
