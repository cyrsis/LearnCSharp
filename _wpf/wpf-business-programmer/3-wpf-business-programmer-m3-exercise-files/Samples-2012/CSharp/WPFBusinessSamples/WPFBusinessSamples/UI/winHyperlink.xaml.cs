using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winHyperlink.xaml
  /// </summary>
  public partial class winHyperlink : Window
  {
    public winHyperlink()
    {
      InitializeComponent();
    }

    private void lnkAbout_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
    {
      winAbout win = new winAbout();

      win.Show();
    }
  }
}
