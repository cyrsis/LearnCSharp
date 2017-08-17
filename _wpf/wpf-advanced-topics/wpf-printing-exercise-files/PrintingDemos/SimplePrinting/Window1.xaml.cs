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
using System.Printing;
using System.Windows.Xps;

namespace SimplePrinting
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, RoutedEventArgs e)
        {
            // 1: Get XpsDocumentWriter

            PrintDocumentImageableArea area = null;
            XpsDocumentWriter dw = PrintQueue.CreateXpsDocumentWriter(ref area);


            // 2: Generate content

            TextBlock tb = new TextBlock(); tb.Text = "Hello, world!";
            tb.Margin = new Thickness(area.OriginWidth, area.OriginHeight, 0, 0);


            // 3: Perform layout

            Size outputSize = new Size(area.MediaSizeWidth, area.MediaSizeHeight);
            tb.Measure(outputSize); tb.Arrange(new Rect(outputSize));
            tb.UpdateLayout();


            // 4: Write content to XpsDocumentWriter

            dw.Write(tb);

        }
    }
}
