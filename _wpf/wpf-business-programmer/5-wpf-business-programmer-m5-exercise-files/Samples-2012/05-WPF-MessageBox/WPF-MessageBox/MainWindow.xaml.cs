using System.Windows;

using PDSA.WPF;

namespace WPF_MessageBox
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnMessageBox_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("This is the normal Message Box");
    }

    private void btnOKOnly_Click(object sender, RoutedEventArgs e)
    {
      PDSAMessageBox.Show("This just displays an OK Button", "OK", MessageBoxButton.OK);
    }

    private void btnYesNo_Click(object sender, RoutedEventArgs e)
    {
      MessageBoxResult result;

      result = PDSAMessageBox.Show("Do you want to Quit?", "Quit?", MessageBoxButton.YesNo);

      MessageBox.Show("Result is " + result.ToString());
    }

    private void btnOkCancel_Click(object sender, RoutedEventArgs e)
    {
      MessageBoxResult result;

      result = PDSAMessageBox.Show("Continue with this process?", "Continue Process...", MessageBoxButton.OKCancel);

      MessageBox.Show("Result is " + result.ToString());
    }

    private void btnYesNoCancel_Click(object sender, RoutedEventArgs e)
    {
      MessageBoxResult result;

      result = PDSAMessageBox.Show("Continue with this one process or Cancel all processes?", "Continue or Cancel All?", MessageBoxButton.YesNoCancel);

      MessageBox.Show("Result is " + result.ToString());
    }
  }
}
