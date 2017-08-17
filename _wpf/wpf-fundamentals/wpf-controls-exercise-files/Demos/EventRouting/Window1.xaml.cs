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
using System.Diagnostics;

namespace EventRouting
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            this.MouseEnter += MouseEnterHandler;
            myBorder.MouseEnter += MouseEnterHandler;
            myPanel.MouseEnter += MouseEnterHandler;
            myEllipse.MouseEnter += MouseEnterHandler;
            myRectangle.MouseEnter += MouseEnterHandler;

            this.MouseDown += MouseDownHandler;
            myBorder.MouseDown += MouseDownHandler;
            myPanel.MouseDown += MouseDownHandler;
            myEllipse.MouseDown += MouseDownHandler;
            myRectangle.MouseDown += MouseDownHandler;

            for (int i = 1; i <= 5; ++i)
            {
                Button btn = new Button();
                btn.Content = "Button " + i;
                myPanel.Children.Add(btn);

                //btn.Click += new RoutedEventHandler(btn_Click);
            }

            myPanel.AddHandler(Button.ClickEvent, new RoutedEventHandler(btn_Click));
        }

        void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button) e.Source;
            btn.Background = Brushes.Green;
        }

        void MouseEnterHandler(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("MouseEnter: " + sender);
        }
        void MouseDownHandler(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("MouseDown: " + sender);
            e.Handled = true;
        }

    }
}
