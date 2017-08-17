using System.Windows;
using System.Windows.Input;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winWindowEllipse.xaml
  /// </summary>
  public partial class winWindowEllipse : Window
  {
    public winWindowEllipse()
    {
      InitializeComponent();
    }
    
    void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      // Call DragMove to move the window around the screen
      this.DragMove();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
