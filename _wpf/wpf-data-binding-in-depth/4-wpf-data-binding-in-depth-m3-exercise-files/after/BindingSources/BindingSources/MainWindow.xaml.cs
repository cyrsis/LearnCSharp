using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Zza.Data;

namespace BindingSources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DeleteCustomerCommand = new RelayCommand<Customer>(OnDeleteCustomer);
            DeleteSelectedCommand = new RelayCommand<Customer>(OnDeleteCustomer, CanDeleteCustomer);
            using (ZzaDbContext context = new ZzaDbContext())
            {
                Customers = new ObservableCollection<Customer>(context.Customers.Include("Orders").Include("Orders.OrderItems").Include("Orders.OrderItems.Product"));
            }
        }

        public RelayCommand<Customer> DeleteCustomerCommand
        {
            get { return (RelayCommand<Customer>)GetValue(DeleteCustomerCommandProperty); }
            set { SetValue(DeleteCustomerCommandProperty, value); }
        }

        public static readonly DependencyProperty DeleteCustomerCommandProperty =
            DependencyProperty.Register("DeleteCustomerCommand",
            typeof(RelayCommand<Customer>),
            typeof(MainWindow),
            new PropertyMetadata(null));


        public RelayCommand<Customer> DeleteSelectedCommand
        {
            get { return (RelayCommand<Customer>)GetValue(DeleteSelectedCommandProperty); }
            set { SetValue(DeleteSelectedCommandProperty, value); }
        }

        public static readonly DependencyProperty DeleteSelectedCommandProperty =
            DependencyProperty.Register("DeleteSelectedCommand",
            typeof(RelayCommand<Customer>),
            typeof(MainWindow),
            new PropertyMetadata(null));

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

        private void OnDeleteCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }
        private bool CanDeleteCustomer(Customer customer)
        {
            return customerDataGrid.SelectedItem != null;
        }

        private void customerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteSelectedCommand.RaiseCanExecuteChanged();
        }
    }
}
