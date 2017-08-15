using System;
using System.Windows;

namespace CustomerDataViewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadData_OnClick(object sender, RoutedEventArgs e)
        {
           DataContext = CustomerDataServiceTyped.GetCustomerData();
           // DataContext = CustomerDataServiceDynamic.GetCustomerData();
        }
    }
}
