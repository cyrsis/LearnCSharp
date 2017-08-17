using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winStatusBarPanels.xaml
  /// </summary>
  public partial class winStatusBarPanels : Window
  {
    public winStatusBarPanels()
    {
      InitializeComponent();
    }

    private void btnHelp_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Help");
    }
  }
}
