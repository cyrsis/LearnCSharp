using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winChild.xaml
  /// </summary>
  public partial class winChild : Window
  {
    public winChild()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
