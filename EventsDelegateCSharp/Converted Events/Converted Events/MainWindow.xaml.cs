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

namespace Converted_Events
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

        private void yesButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_PreviewMouseDown");
        }

        private void noButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("noButton_PreviewMouseDown");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("Grid_Click");
        }

        private void outerStackPanel_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_Click");
        }

        private void innerStackPanel_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_Click");
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_Click");
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("noButton_Click");
        }

        private void Grid_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Grid_PreviewMouseUp");
        }

        private void outerStackPanel_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_PreviewMouseUp");
        }

        private void innerStackPanel_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_PreviewMouseUp");
        }

        private void yesButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_PreviewMouseUp");
        }

        private void noButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("noButton_PreviewMouseUp");
        }

        private void yesButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_MouseDown");
        }

        private void yesButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("yesButton_MouseUp");
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Grid_MouseDown");
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Grid_MouseUp");
        }

        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Label_PreviewMouseDown");
        }

        private void Label_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Label_PreviewMouseUp");
        }

        private void Label_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("Label_Click");
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Label_MouseDown");
        }

        private void Label_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Label_MouseUp");
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Clear();
            resultsListBox.Items.Add("Window_PreviewMouseDown");
        }

        private void Window_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("-----");
            resultsListBox.Items.Add("Window_PreviewMouseUp");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Window_MouseDown");
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("Window_MouseUp");
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            resultsListBox.Items.Add("Window_Click");
        }

        private void outerStackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_MouseDown");
        }

        private void outerStackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("outerStackPanel_MouseUp");
        }

        private void innerStackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_MouseDown");
        }

        private void innerStackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resultsListBox.Items.Add("innerStackPanel_MouseUp");
        }
    }
}
