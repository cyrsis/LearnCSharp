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
            CollectionViewSource productViewSource =
                ((CollectionViewSource)(this.FindResource("productViewSource")));
            using (ZzaDbContext context = new ZzaDbContext())
            {
                productViewSource.Source = context.Products.ToList();
            }

            //ShowTree(GetTreeFromNode(productListBox));

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
            ShowTree(GetTreeFromNode(sender as DependencyObject));
        }

        void ShowTree(TreeViewItem tree)
        {
            Window popup = new Window();
            TreeView treeView = new TreeView();
            treeView.Items.Add(tree);
            popup.Content = treeView;
            popup.Width = 700;
            popup.Height = 300;
            popup.FontSize = 16;
            popup.Show();
        }

        TreeViewItem GetTreeFromNode(DependencyObject node)
        {
            TreeViewItem nodeAndChildren = GetVisualTree(node, true);
            var parent = GetParent(node);
            var child = nodeAndChildren;
            TreeViewItem parentNode = null;
            while (parent != null)
            {
                parentNode = new TreeViewItem();
                parentNode.Header = GetNodeLabel(parent);
                parentNode.Items.Add(child);
                child = parentNode;
                parent = GetParent(parent);
            }
            return parentNode;
        }

        TreeViewItem GetVisualTree(DependencyObject rootObject, bool highlight)
        {
            TreeViewItem rootItem = new TreeViewItem();
            if (highlight) rootItem.Header = "[[" + GetNodeLabel(rootObject) + "]]";
            else rootItem.Header = GetNodeLabel(rootObject);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(rootObject); i++)
            {
                rootItem.Items.Add(GetVisualTree(VisualTreeHelper.GetChild(rootObject, i), false));
            }
            return rootItem;
        }

        DependencyObject GetParent(DependencyObject depObj)
        {
            FrameworkElement element = depObj as FrameworkElement;
            if (element != null && element.Parent != null) return element.Parent;
            else return VisualTreeHelper.GetParent(depObj);
        }

        string GetNodeLabel(object node)
        {
            var dcType = node is FrameworkElement ? (((FrameworkElement)node).DataContext == null ? "null" : ((FrameworkElement)node).DataContext.GetType().Name) : "null";
            var nodeName = node.GetType().Name;
            var fe = node as FrameworkElement;
            if (fe != null && !string.IsNullOrWhiteSpace(fe.Name)) nodeName = nodeName + " : " + fe.Name;
            return string.Format("{0} - DataContext: {1}", nodeName, dcType);
        }


    }
}
