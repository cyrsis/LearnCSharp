using System;
using System.Windows;
using System.Windows.Controls;
using Anotar.NLog;

namespace DemoWpfApplication
{
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {
            InitializeComponent();

            FirstNum.ItemsSource = new[] {10, 20, 30};
            SecondNum.ItemsSource = new[] { 0, 2, 10 };

            LogTo.Trace("Main Loaded");
        }

        private void Divide_OnClick(object sender, RoutedEventArgs e)
        {
            LogTo.Info("Divide clicked");

            var result = DivideNumbers((int)FirstNum.SelectedValue, (int)SecondNum.SelectedValue);

            Output.Text = result.ToString();
        }

        [LogToErrorOnException]
        private int DivideNumbers(int a, int b)
        {           
            return a / b;            
        }

        private void FirstNum_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LogTo.Trace("FirstNum changed");
        }

        private void SecondNum_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LogTo.Trace("SecondNum changed");
        }
    }
}
