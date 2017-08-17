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
using System.Collections.ObjectModel;
using System.Threading;

namespace BrokenAsyncListBinding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<string> sourceList = new ObservableCollection<string>();

        public Window1()
        {
            InitializeComponent();

            this.DataContext = sourceList;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                string text = "Item " + nextId++;

                sourceList.Add(text);
            });
        }
        int nextId = 1;
    }
}
