using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CustomControlDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddHandler(Button.ClickEvent, new RoutedEventHandler(Window_Click), true);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
