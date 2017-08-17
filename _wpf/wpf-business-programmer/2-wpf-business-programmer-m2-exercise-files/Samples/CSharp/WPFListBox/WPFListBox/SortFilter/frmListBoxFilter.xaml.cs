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
using System.Windows.Shapes;

using WPFComponents;
using System.ComponentModel;

namespace WPFListBox
{
  /// <summary>
  /// Interaction logic for frmListBoxFilter.xaml
  /// </summary>
  public partial class frmListBoxFilter : Window
  {
    public frmListBoxFilter()
    {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, RoutedEventArgs e)
    {
      FilterData();
    }

    private void FilterData()
    {
      // For Filtering to work, the ItemsSource must use the ToList()
      // It must be IEnumerable<Customer>
      if (lstCustomers != null)
      {
        ICollectionView dataView =
            CollectionViewSource.GetDefaultView(
               lstCustomers.ItemsSource);

        dataView.Filter = cust =>
           ((Customer)cust).LastName.ToLower().
             StartsWith(txtLast.Text.ToLower());

        lstCustomers.ItemsSource = dataView;
      }
    }
  }
}
