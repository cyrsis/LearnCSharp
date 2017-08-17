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

namespace DataBindingBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZzaEntities _ZzaContext = new ZzaEntities();
        MainWindowViewModel _ViewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            var firstCustomer = _ZzaContext.Customers.FirstOrDefault();
            //CustomerIdLabel.Content = firstCustomer.Id;
            //CustomerLastNameTextBox.Text = firstCustomer.LastName;
            //DataContext = firstCustomer;
            _ViewModel.Customer = firstCustomer;
            // Sets DataContext for Window and all child elements
            var orderDates = _ZzaContext.Orders
                .Where(o => o.CustomerId == firstCustomer.Id).Select(o => o.OrderDate).ToList();
            //OrdersList.ItemsSource = orderDates;
            //OrdersList.DataContext = orderDates;
            _ViewModel.OrderDates = orderDates;
            DataContext = _ViewModel;
        }

        void OnOrderSelected(object sender, SelectionChangedEventArgs args)
        {
            var selectedOrder = _ZzaContext.Orders.Include("OrderItems")
                .Where(o => o.OrderDate == (DateTime)OrdersList.SelectedItem && 
                    o.CustomerId == (Guid)CustomerIdLabel.Content).FirstOrDefault();
            //OrderItemsDataGrid.ItemsSource = selectedOrder.OrderItems;
            //OrderItemsDataGrid.DataContext = selectedOrder.OrderItems;
            _ViewModel.OrderItems = selectedOrder.OrderItems.ToList();
            //DataContext = null;
            DataContext = _ViewModel;
            OrderItemsDataGrid.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();
        }

        private void OnSave(object sender, RoutedEventArgs e)
        {
            //var customer = _ZzaContext.Customers.Where(c => c.Id == (Guid)(CustomerIdLabel.Content)).FirstOrDefault();
            //customer.LastName = CustomerLastNameTextBox.Text;
            // Get all the other editable field values...
            // Persist those changes somewhere
            _ZzaContext.SaveChanges();
        }
    }
}
