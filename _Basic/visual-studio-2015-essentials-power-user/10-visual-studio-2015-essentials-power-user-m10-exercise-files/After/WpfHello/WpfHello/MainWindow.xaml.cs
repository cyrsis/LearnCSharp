﻿using System;
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
using GreetingLogic;

namespace WpfHello
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Greeting logic = new Greeting();
            //use business logic to get a greeting
            MessageBox.Show(logic.GetString());
            return;
            }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void NewThing_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
