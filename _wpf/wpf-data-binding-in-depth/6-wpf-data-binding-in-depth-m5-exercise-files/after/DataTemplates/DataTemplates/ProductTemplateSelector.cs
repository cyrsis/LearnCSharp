using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Zza.Data;

namespace DataTemplates
{
    public class ProductTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Product product = item as Product;
            FrameworkElement element = container as FrameworkElement;
            if (product == null || element == null) return null;

            DataTemplate template = element.FindResource(product.Type + "Template") as DataTemplate;
            return template;
        }
    }
}
