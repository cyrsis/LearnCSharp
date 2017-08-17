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

namespace BindingProperties
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

        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }
            set { SetValue(CustomerProperty, value); }
        }

        public static readonly DependencyProperty CustomerProperty =
            DependencyProperty.Register("Customer", typeof(Customer), typeof(MainWindow), new PropertyMetadata(null));

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Customer = new Customer
            {
                Id = 42,
                Name = "Joe",
                PremiumCustomer = true,
                Age = 35
            };
        }

        private void TriggerCustomerChange(object sender, RoutedEventArgs e)
        {
            Customer.Name = "Changed behind the scenes";
        }
    }
}
