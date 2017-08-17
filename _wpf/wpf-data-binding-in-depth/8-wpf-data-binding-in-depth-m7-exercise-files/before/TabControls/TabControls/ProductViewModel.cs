using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zza.Data;

namespace TabControls
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private string _ProductType;
        private ObservableCollection<Product> _Products;

        public ProductViewModel(string type)
        {
            ProductType = type;
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                using (ZzaDbContext context = new ZzaDbContext())
                {
                    Products = new ObservableCollection<Product>(context.Products.Where(p => p.Type == type));
                    Products.ToList().ForEach(p => p.Image = "Images/" + p.Image);
                }
            }
        }

        public string ProductType
        {
            get
            {
                return _ProductType;
            }
            set
            {
                if (value != _ProductType)
                {
                    _ProductType = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ProductType"));
                }
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
