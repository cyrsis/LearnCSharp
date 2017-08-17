using Sixeyed.SpecFlowItAll.Domain.Model;
using Sixeyed.SpecFlowItAll.Domain.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sixeyed.SpecFlowItAll.WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var products = new List<Product>();
            using (var context = new ShopContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                products.AddRange(context.Products.Include("Supplier"));
            }
            var productViewSource = ((CollectionViewSource) (this.FindResource("productViewSource")));
            productViewSource.Source = products;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Reorder_Click(object sender, RoutedEventArgs e)
        {
            var productCode = ((Button)sender).CommandParameter as string;
            UpdateProduct(productCode, true);
            Supplier supplier = null;
            using (var context = new ShopContext())
            {
                supplier = context.Products.FirstOrDefault(x => x.Code == productCode).Supplier;
            }
            var reorderStrategy = SupplierReorderStrategyFactory.Get(supplier);
            reorderStrategy.Reorder(productCode);
        }

        private void Discontinue_Click(object sender, RoutedEventArgs e)
        {
            var productCode = ((Button)sender).CommandParameter as string;
            UpdateProduct(productCode, false);
        }

        private void UpdateProduct(string productCode, bool isAvailable)
        {
            using (var context = new ShopContext())
            {
                var product = context.Products.FirstOrDefault(x => x.Code == productCode);
                if (product != null)
                {
                    product.StockCount = 0;
                    product.IsAvailable = isAvailable;
                }
                context.SaveChanges();
            }
            LoadGrid();
        }
    }
}
