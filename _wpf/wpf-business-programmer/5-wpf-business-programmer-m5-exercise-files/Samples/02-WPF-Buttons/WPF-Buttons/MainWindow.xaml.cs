using System.Windows;

namespace WPF_Buttons
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Hello from normal button");
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Hello From Gray Style");
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Hello From Flat Blue Style");
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Hello From Flat Red Style");
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Hello From Blue Style");
    }  
  }
}
