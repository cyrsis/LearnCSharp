using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winAbout.xaml
  /// </summary>
  public partial class winAbout : Window
  {
    public winAbout()
    {
      InitializeComponent();
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
