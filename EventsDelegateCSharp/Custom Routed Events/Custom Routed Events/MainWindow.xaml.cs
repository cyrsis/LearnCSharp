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

namespace Custom_Routed_Events
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

        private void Window_PreviewIncrement(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Clear();
            eventsListBox.Items.Add("Window_PreviewIncrement");
            //e.Handled = true;
        }

        private void Grid_PreviewIncrement(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add("Grid_PreviewIncrement");
        }

        private void CountingButton_PreviewIncrement(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add("CountingButton_PreviewIncrement");
        }




        private void Window_Increment(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add("Window_Increment");
        }

        private void Grid_Increment(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add("Grid_Increment");
        }

        private void CountingButton_Increment(object sender, RoutedEventArgs e)
        {
            eventsListBox.Items.Add("CountingButton_Increment");
        }
    }
}
