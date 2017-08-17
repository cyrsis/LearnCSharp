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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace EntityDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZzaDbContext _DbContext = new ZzaDbContext();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Customers = new ObservableCollection<Customer>(_DbContext.Customers);
            OrderStatuses = _DbContext.OrderStatuses.ToList();
            CustomersCombo.SelectedItem = Customers[0];
            OrderStatusCombo.SelectedIndex = 0;
        }

        public ObservableCollection<Customer> Customers
        {
            get { return (ObservableCollection<Customer>)GetValue(CustomersProperty); }
            set { SetValue(CustomersProperty, value); }
        }

        public static readonly DependencyProperty CustomersProperty =
            DependencyProperty.Register("Customers",
            typeof(ObservableCollection<Customer>),
            typeof(MainWindow),
            new PropertyMetadata(null));

        public Customer SelectedCustomer
        {
            get { return (Customer)GetValue(SelectedCustomerProperty); }
            set { SetValue(SelectedCustomerProperty, value); }
        }

        public static readonly DependencyProperty SelectedCustomerProperty =
            DependencyProperty.Register("SelectedCustomer",
            typeof(Customer),
            typeof(MainWindow),
            new PropertyMetadata(null));

        public Order NewOrder
        {
            get { return (Order)GetValue(NewOrderProperty); }
            set { SetValue(NewOrderProperty, value); }
        }

        public static readonly DependencyProperty NewOrderProperty =
            DependencyProperty.Register("NewOrder", typeof(Order), typeof(MainWindow), new PropertyMetadata(null));


        public List<OrderStatus> OrderStatuses
        {
            get { return (List<OrderStatus>)GetValue(OrderStatusesProperty); }
            set { SetValue(OrderStatusesProperty, value); }
        }

        public static readonly DependencyProperty OrderStatusesProperty =
            DependencyProperty.Register("OrderStatuses", typeof(List<OrderStatus>), typeof(MainWindow), new PropertyMetadata(null));



        private void OnAdd(object sender, RoutedEventArgs e)
        {
            SelectedCustomer.Orders.Add(NewOrder);
            _DbContext.Orders.Add(NewOrder);
            _DbContext.SaveChanges();
            NewOrder = new Order { CustomerId = SelectedCustomer.Id };
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            NewOrder.CancelEdit();
        }

        private void OnCustomerSelected(object sender, SelectionChangedEventArgs e)
        {
            SelectedCustomer = CustomersCombo.SelectedItem as Customer;
            NewOrder = new Order();
            NewOrder.BeginEdit();
            NewOrder.CustomerId = SelectedCustomer.Id;
            SelectedCustomer.Orders = new ObservableCollection<Order>(_DbContext.Orders.Where(o => o.CustomerId == SelectedCustomer.Id));
        }

        private void OnMoveDown(object sender, RoutedEventArgs e)
        {
            ICollectionView collView = CollectionViewSource.GetDefaultView(SelectedCustomer.Orders);
            if (collView.CurrentPosition > 0)
                collView.MoveCurrentToPrevious();
        }

        private void OnMoveUp(object sender, RoutedEventArgs e)
        {
            ICollectionView collView = CollectionViewSource.GetDefaultView(SelectedCustomer.Orders);
            if (collView.CurrentPosition < SelectedCustomer.Orders.Count - 1)
                collView.MoveCurrentToNext();
        }
    }
}
