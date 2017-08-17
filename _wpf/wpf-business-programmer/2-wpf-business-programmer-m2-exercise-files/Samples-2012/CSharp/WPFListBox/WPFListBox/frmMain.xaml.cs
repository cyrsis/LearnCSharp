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

namespace WPFListBox
{
  /// <summary>
  /// Interaction logic for frmMain.xaml
  /// </summary>
  public partial class frmMain : Window
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void btnListBox2Templates_Click(object sender, RoutedEventArgs e)
    {
      frmListBox2Templates frm = new frmListBox2Templates();

      frm.Show();
    }

    private void btnListFormat_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxFormat frm = new frmListBoxFormat();

      frm.Show();
    }

    private void btnListFormatConverter_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxFormatConverter frm = new frmListBoxFormatConverter();

      frm.Show();
    }

    private void btnListImage_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxWithImage frm = new frmListBoxWithImage();

      frm.Show();
    }

    private void btnListBoxSortingUsingXaml_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxSortUsingXaml frm = new frmListBoxSortUsingXaml();

      frm.Show();
    }

    private void btnListBoxFilter_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxFilter frm = new frmListBoxFilter();

      frm.Show();
    }

    private void btnListBoxSortingUsingCode_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxSortUsingCode frm = new frmListBoxSortUsingCode();

      frm.Show();
    }

    private void btnDataTriggerConverter_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxDataTriggerConverter frm = new frmListBoxDataTriggerConverter();

      frm.Show();
    }

    private void btnObjectConverter_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxConverterObject frm = new frmListBoxConverterObject();

      frm.Show();
    }

    private void btnListBoxDataProvider_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxDataProvider frm = new frmListBoxDataProvider();

      frm.Show();
    }
  }
}