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
  /// Interaction logic for frmListBox2Templates.xaml
  /// </summary>
  public partial class frmListBox2Templates : Window
  {
    public frmListBox2Templates()
    {
      InitializeComponent();
    }

    private void btnMore_Click(object sender, RoutedEventArgs e)
    {
      DataTemplate tmpl;

      tmpl = (DataTemplate)this.FindResource("tmplMore");
      if(tmpl != null)
        lstData.ItemTemplate = tmpl;
    }

    private void btnLess_Click(object sender, RoutedEventArgs e)
    {
      DataTemplate tmpl;

      tmpl = (DataTemplate)this.FindResource("tmplLess");
      if (tmpl != null)
        lstData.ItemTemplate = tmpl;
    }
  }
}
