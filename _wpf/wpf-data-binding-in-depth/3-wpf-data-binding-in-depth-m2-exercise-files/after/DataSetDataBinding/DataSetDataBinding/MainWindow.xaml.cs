using DataSetDataBinding.CustomersDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace DataSetDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomersDataSet _DataSet = new CustomersDataSet();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CustomerTableAdapter tableAdapter = new CustomerTableAdapter();
            Customers = tableAdapter.GetData();
        }

        public CustomersDataSet.CustomerDataTable Customers
        {
            get { return (CustomersDataSet.CustomerDataTable)GetValue(CustomersProperty); }
            set { SetValue(CustomersProperty, value); }
        }

        public static readonly DependencyProperty CustomersProperty =
            DependencyProperty.Register("Customers", 
            typeof(CustomersDataSet.CustomerDataTable), 
            typeof(MainWindow), 
            new PropertyMetadata(null));

        public DataRowView SelectedCustomer
        {
            get { return (DataRowView)GetValue(SelectedCustomerProperty); }
            set { SetValue(SelectedCustomerProperty, value); }
        }

        public static readonly DependencyProperty SelectedCustomerProperty =
            DependencyProperty.Register("SelectedCustomer", 
            typeof(DataRowView), 
            typeof(MainWindow), 
            new PropertyMetadata(null));

        private void OnCustomerSelected(object sender, SelectionChangedEventArgs e)
        {
            SelectedCustomer = CustomersCombo.SelectedItem as DataRowView;
        }

    }
}
