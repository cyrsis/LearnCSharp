using System.Windows;

using WPFComponents;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winLoadUserControl.xaml
  /// </summary>
  public partial class winLoadUserControl : Window
  {
    public winLoadUserControl()
    {
      InitializeComponent();
    }

    private void btnLoad_Click(object sender, RoutedEventArgs e)
    {
      btnLoad.IsEnabled = false;

      ucAddress ucaddr = new ucAddress();
      Address addr = new Address();

      stpMain.Children.Add(ucaddr);

      ucaddr.DataContext = addr.CreateSample();
    }
  }
}
