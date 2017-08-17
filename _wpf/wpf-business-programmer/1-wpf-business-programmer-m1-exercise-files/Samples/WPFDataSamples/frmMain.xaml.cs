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

namespace WPFDataSamples
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

    #region List Boxes
    private void btn2ColumnListBox_Click(object sender, RoutedEventArgs e)
    {
      frmListBox2Columns frm = new frmListBox2Columns();

      frm.Show();
    }

    private void btnListBoxMultiLine_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxMultiLine frm = new frmListBoxMultiLine();

      frm.Show();
    }

    private void btnHorizontalList_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxHorizontal frm = new frmListBoxHorizontal();

      frm.Show();
    }

    private void btnListBoxDataTrigger_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxDataTrigger frm = new frmListBoxDataTrigger();

      frm.Show();
    }

    private void btnListBoxWithGrouping_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxWithGrouping1 frm = new frmListBoxWithGrouping1();

      frm.Show();
    }

    private void btnListBoxWithGrouping2_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxWithGrouping2 frm = new frmListBoxWithGrouping2();

      frm.Show();
    }

    private void btnListBoxSelect_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxSelect frm = new frmListBoxSelect();

      frm.Show();
    }

    private void btnListBoxSelectModify_Click(object sender, RoutedEventArgs e)
    {
      frmListBoxSelectModify frm = new frmListBoxSelectModify();

      frm.Show();
    }
    #endregion
  }
}