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
            using (ZzaDbContext context = new ZzaDbContext())
            {
                Customers = new ObservableCollection<Customer>(context.Customers);
            }
            DataContext = this;
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

        private void customerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
