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
            string simplestring = "Hello";
            string xmlstring = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><things><thing id=\"1\" name=\"Crate\" weight=\"5\"/></things>";
            xmlstring = xmlstring.Replace("thing", "Thing");
            DateTime today = DateTime.Now;
            System.Data.DataTable fakedata = GreetingLogic.Greeting.GetData();
            int x = GetNumber() + 2;
            x++;
            x++;
            simplestring += " " + x.ToString();

            for (int i = 0; i < 100; i++)
            {
                x = i * 10;
            }

            Greeting logic = new Greeting();
            //use business logic to get a greeting
            MessageBox.Show(logic.GetString());
            return;
        }
        private static int GetNumber()
        {
            return 3;
        }
    }
}
