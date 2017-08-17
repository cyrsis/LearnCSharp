using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winTooltips.xaml
  /// </summary>
  public partial class winTooltips : Window
  {
    public winTooltips()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
