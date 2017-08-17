using System.Windows;
using System.Windows.Input;

namespace WPF_ImageButton
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      if (e.ButtonState == MouseButtonState.Pressed)
        this.DragMove();
    }
    
    private void btnMinimize_Click(object sender, RoutedEventArgs e)
    {
      WindowState = WindowState.Minimized;
    }

    private void btnMaximize_Click(object sender, RoutedEventArgs e)
    {
      if (this.WindowState == WindowState.Normal)
        WindowState = WindowState.Maximized;
      else
        WindowState = WindowState.Normal;
    }

    private void btnClose_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }  
  }
}