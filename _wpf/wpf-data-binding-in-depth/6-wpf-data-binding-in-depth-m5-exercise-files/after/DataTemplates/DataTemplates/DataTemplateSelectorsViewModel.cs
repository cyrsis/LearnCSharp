using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Zza.Data;

namespace DataTemplates
{
    public class DataTemplateSelectorsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Product> _Products;

        public DataTemplateSelectorsViewModel()
        {
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                ZzaDbContext context = new ZzaDbContext();
                Products = new ObservableCollection<Product>(context.Products.ToList());
            }
        }
        public ObservableCollection<Product> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                if (value != _Products)
                {
                    _Products = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Products"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
