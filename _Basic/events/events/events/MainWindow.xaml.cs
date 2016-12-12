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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button helpButton = new Button();
            helpButton.Content = "Get Help";
            helpButton.Click += new RoutedEventHandler(helpButton_Click);
            MainContent.Children.Add(helpButton);

            Book book = new Book() { Title = "C# Cookbook", Price = 29.99m };
            book.OnPurchaseMade += new EventHandler(book_OnPurchaseMade);
            book.Purchase();

        }

        void book_OnPurchaseMade(object sender, EventArgs e)
        {
            InformationArea.Text = "purchase was made";
        }

        void helpButton_Click(object sender, RoutedEventArgs e)
        {
            InformationArea.Text = "this is the help";
            Book book2 = new Book() { Title = "VB.NET Cookbook", Price = 29.00m };
            book2.OnPurchaseMade += new EventHandler(book2_OnPurchaseMade);
            book2.Purchase();
        }

        void book2_OnPurchaseMade(object sender, EventArgs e)
        {
            ButtonInformation.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InformationArea.Text = "this is the infomation";
        }

        private void InformationArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            InformationArea.Text = "you clicked the information area";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public event EventHandler OnPurchaseMade;

        public void Purchase()
        {
            //make database changes...
            if(OnPurchaseMade != null)
                OnPurchaseMade(this, null);
        }

    }


}
