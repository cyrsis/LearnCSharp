using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winLogin2.xaml
  /// </summary>
  public partial class winLogin2 : Window
  {
    public winLogin2()
    {
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = true;
      this.Close();
    }

    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
      DialogResult = false;
      this.Close();
    }
  }
}
