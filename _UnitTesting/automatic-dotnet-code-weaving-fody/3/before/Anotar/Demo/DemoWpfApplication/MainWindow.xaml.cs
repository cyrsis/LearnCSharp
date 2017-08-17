using System;
using System.Windows;
using System.Windows.Controls;

namespace DemoWpfApplication
{
    public partial class MainWindow : Window
    {
       private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();

            FirstNum.ItemsSource = new[] {10, 20, 30};
            SecondNum.ItemsSource = new[] { 0, 2, 10 };

            logger.Trace("Main Loaded");
        }

        private void Divide_OnClick(object sender, RoutedEventArgs e)
        {
            logger.Info("Divide clicked");

            var result = DivideNumbers((int)FirstNum.SelectedValue, (int)SecondNum.SelectedValue);

            Output.Text = result.ToString();
        }


        private int DivideNumbers(int a, int b)
        {           
            return a / b;            
        }

        private void FirstNum_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logger.Trace("FirstNum changed");
        }

        private void SecondNum_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            logger.Trace("SecondNum changed");
        }
    }
}
