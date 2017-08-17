using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winLogin.xaml
  /// </summary>
  public partial class winLogin : Window
  {
    public winLogin()
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
