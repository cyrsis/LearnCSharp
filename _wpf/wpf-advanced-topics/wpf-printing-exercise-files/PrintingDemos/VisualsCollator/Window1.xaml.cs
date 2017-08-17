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
using System.Windows.Documents.Serialization;

namespace VisualsCollator
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
            PrintDocumentImageableArea area = null;
            XpsDocumentWriter dw = PrintQueue.CreateXpsDocumentWriter(ref area);
            SerializerWriterCollator c = dw.CreateVisualsCollator();
            c.BeginBatchWrite();
            for (int i = 1; i <= 10; ++i)
            {
                TextBlock tb = new TextBlock();
                tb.Text = i.ToString();
                tb.TextAlignment = TextAlignment.Center;
                tb.VerticalAlignment = VerticalAlignment.Center;
                tb.FontSize = 500;
                tb.FontFamily = new FontFamily("Consolas");

                tb.Margin = new Thickness(area.OriginWidth, area.OriginHeight, 0, 0);
                Size outputSize = new Size(area.MediaSizeWidth, area.MediaSizeHeight);
                tb.Measure(outputSize);
                tb.Arrange(new Rect(outputSize));
                tb.UpdateLayout();

                c.Write(tb);
            }
            c.EndBatchWrite();

        }
    }
}
