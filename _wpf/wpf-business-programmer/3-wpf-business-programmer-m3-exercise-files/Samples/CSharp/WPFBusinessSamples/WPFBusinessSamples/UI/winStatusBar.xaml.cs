using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winStatusBar.xaml
  /// </summary>
  public partial class winStatusBar : Window
  {
    public winStatusBar()
    {
      InitializeComponent();
    }

    private void btnHelp_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Help");
    }
  }
}
