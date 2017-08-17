using System.Windows;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winWindowNoBorder.xaml
  /// </summary>
  public partial class winWindowNoBorder : Window
  {
    public winWindowNoBorder()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
