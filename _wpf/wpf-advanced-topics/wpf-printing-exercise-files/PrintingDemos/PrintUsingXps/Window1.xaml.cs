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
using System.Windows.Markup;

namespace PrintUsingXps
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
            XpsDocumentWriter wr = PrintQueue.CreateXpsDocumentWriter(ref area);


            FixedDocument doc = new FixedDocument();
            for (int page = 1; page <= 5; ++page)
            {
                FixedPage fpage = new FixedPage();
                TextBlock tb = new TextBlock();
                tb.Text = "Page " + page;
                tb.FontFamily = new FontFamily("Calibri");
                tb.FontSize = 80;
                tb.HorizontalAlignment = HorizontalAlignment.Center;
                tb.VerticalAlignment = VerticalAlignment.Center;

                Border content = new Border();
                content.Child = tb;
                content.Width = area.ExtentWidth;
                content.Height = area.ExtentHeight;

                FixedPage.SetLeft(content, area.OriginWidth);
                FixedPage.SetTop(content, area.OriginHeight);

                
                fpage.Children.Add(content);

                PageContent pc = new PageContent();
                ((IAddChild) pc).AddChild(fpage);
                doc.Pages.Add(pc);
            }

            wr.Write(doc);
        }
    }
}
