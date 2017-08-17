using System.Windows;

namespace WPF_ButtonImageText
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnEdit_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Edit");
    }

    private void btnNew_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("New");
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Save");
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Delete");
    }  
  }
}
