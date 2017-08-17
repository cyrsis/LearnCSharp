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

namespace XamlWithCodebehind
{
    /// <summary>
    /// Interaction logic for MyGrid.xaml
    /// </summary>
    public partial class MyGrid : Grid
    {
        public MyGrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            textBlock1.Text = (x + y).ToString();
        }
    }
}
