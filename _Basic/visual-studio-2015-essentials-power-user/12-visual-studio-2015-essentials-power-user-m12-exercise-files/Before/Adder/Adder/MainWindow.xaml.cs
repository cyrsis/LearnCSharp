using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Adder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Logic.Data internaldata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetData_Click(object sender, RoutedEventArgs e)
        {
            internaldata = new Logic.Data();
            number1.Text = internaldata.Number1.ToString();
            number2.Text = internaldata.Number2.ToString();
            number3.Text = internaldata.Number3.ToString();
        }

        private void RefreshTotal_Click(object sender, RoutedEventArgs e)
        {
            TotalLabel.Content = internaldata.Total + Int32.Parse(yournumber.Text);
        }
    }
}
