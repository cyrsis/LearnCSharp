using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Zza.Data;

namespace ComboAndListBoxes
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _SearchInput;
        private int _SelectedProductId;
        private Product _SelectedProduct;
        private ObservableCollection<Product> _Products;

        public MainWindowViewModel()
        {
            SetProductCommand = new RelayCommand(OnSetProduct);
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                using (ZzaDbContext context = new ZzaDbContext())
                {
                    var products = new ObservableCollection<Product>(context.Products);
                    products.ToList().ForEach(p => p.Image = "Images/" + p.Image);
                    SelectedProductId = products[0].Id;
                    SelectedProduct = products[0];
                    Products = products;
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

        public Product SelectedProduct
        {
            get
            {
                return _SelectedProduct;
            }
            set
            {
                if (value != _SelectedProduct)
                {
                    _SelectedProduct = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedProduct"));
                }
            }
        }

        public int SelectedProductId
        {
            get
            {
                return _SelectedProductId;
            }
            set
            {
                if (value != _SelectedProductId)
                {
                    _SelectedProductId = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedProductId"));
                }
            }
        }

        public string SearchInput
        {
            get
            {
                return _SearchInput;
            }
            set
            {
                if (value != _SearchInput)
                {
                    _SearchInput = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("SearchInput"));
                }
            }
        }

        public RelayCommand SetProductCommand { get; private set; }
        private void OnSetProduct()
        {
            SelectedProduct = Products.FirstOrDefault(p => p.Name.Contains(SearchInput)); 
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
