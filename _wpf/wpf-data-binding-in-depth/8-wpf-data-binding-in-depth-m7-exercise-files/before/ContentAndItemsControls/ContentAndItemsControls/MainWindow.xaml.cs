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
using Zza.Data;

namespace ContentAndItemsControls
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource productViewSource = 
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            using (ZzaDbContext context = new ZzaDbContext())
            {
                productViewSource.Source = context.Products.ToList();
            }
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            //ShowTree(GetTreeFromNode(sender as DependencyObject));
        }

        bool lbDumpDone = false;
        private void ListBoxTextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            if (lbDumpDone) return;
            lbDumpDone = true;
            //ShowTree(GetTreeFromNode(sender as DependencyObject));
        }

        bool dgDumpDone = false;
        private void DataGridCell_Loaded(object sender, RoutedEventArgs e)
        {
            if (dgDumpDone) return;
            dgDumpDone = true;
            //ShowTree(GetTreeFromNode(sender as DependencyObject));
        }


    }
}
