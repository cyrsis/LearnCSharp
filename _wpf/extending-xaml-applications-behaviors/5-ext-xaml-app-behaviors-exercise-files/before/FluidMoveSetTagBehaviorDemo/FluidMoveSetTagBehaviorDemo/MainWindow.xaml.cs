using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FluidMoveSetTagBehaviorDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            using (ZzaEntities context = new ZzaEntities())
            {
                Products = new ObservableCollection<Product>(context.Products);
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return (ObservableCollection<Product>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        public static readonly DependencyProperty ProductsProperty =
            DependencyProperty.Register("Products", typeof(ObservableCollection<Product>), 
            typeof(MainWindow), new PropertyMetadata(null));



        public Product SelectedProduct
        {
            get { return (Product)GetValue(SelectedProductProperty); }
            set { SetValue(SelectedProductProperty, value); }
        }

        public static readonly DependencyProperty SelectedProductProperty =
            DependencyProperty.Register("SelectedProduct", typeof(Product), 
            typeof(MainWindow), new PropertyMetadata(null));


    }
}
