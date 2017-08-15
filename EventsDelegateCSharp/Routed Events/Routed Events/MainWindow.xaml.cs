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

using System.Reflection;

namespace Routed_Events
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

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Clear();
            resultsListBox.Items.Add("Window_PreviewMouseDown");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Grid_PreviewMouseDown");
        }

        private void outerStackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_PreviewMouseDown");
        }

        private void innerStackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_PreviewMouseDown");
        }

        private void yesLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesLabel_PreviewMouseDown");
        }

        private void noLabel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            resultsListBox.Items.Add("noLabel_PreviewMouseDown");
        }

        private void noButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("noButton_PreviewMouseDown");
        }

        private void yesButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_PreviewMouseDown");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Window_MouseDown");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Grid_MouseDown");
        }

        private void outerStackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_MouseDown");
        }

        private void innerStackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_MouseDown");
        }

        private void yesLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesLabel_MouseDown");
        }

        private void noLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("noLabel_MouseDown");
        }
    }
}
