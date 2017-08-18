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

namespace WpfApplication8
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

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Shape s1 = new Square(DrawingCanvas);
            Circle s2 = new Circle(DrawingCanvas);
            Shape s3 = new Circle(DrawingCanvas);
            

            s1.Draw(); s2.Draw(); s3.Draw();

            for (int i = 0; i < 100; i++)
            {
                DrawShape(new Square(DrawingCanvas));
                DrawShape(new Circle(DrawingCanvas));
            }

        }

        private void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }
}
