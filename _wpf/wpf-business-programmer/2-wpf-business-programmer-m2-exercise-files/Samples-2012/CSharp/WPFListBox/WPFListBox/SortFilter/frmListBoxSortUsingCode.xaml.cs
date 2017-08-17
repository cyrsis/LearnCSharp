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
  /// Interaction logic for frmListBoxSortUsingCode.xaml
  /// </summary>
  public partial class frmListBoxSortUsingCode : Window
  {
    public frmListBoxSortUsingCode()
    {
      InitializeComponent();
    }

    private void SortTheData(object sender, RoutedEventArgs e)
    {
      // For sorting to work, the ItemsSource must use the ToList()
      if (lstCustomers != null)
      {
        ICollectionView dataView =
            CollectionViewSource.GetDefaultView( 
              lstCustomers.ItemsSource);

        dataView.SortDescriptions.Clear();
        dataView.SortDescriptions.Add(
            new SortDescription(
                (sender as RadioButton).Tag.ToString(),
                      ListSortDirection.Ascending));

        lstCustomers.ItemsSource = dataView;
      }
    }
  }
}
