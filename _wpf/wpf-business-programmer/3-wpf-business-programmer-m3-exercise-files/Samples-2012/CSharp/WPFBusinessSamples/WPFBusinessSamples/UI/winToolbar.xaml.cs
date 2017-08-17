using System.Windows;
using System.Windows.Controls;

namespace WPFBusinessSamples
{
  /// <summary>
  /// Interaction logic for winToolbar.xaml
  /// </summary>
  public partial class winToolbar : Window
  {
    public winToolbar()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      // Add Click event handler for each button in the Main toolbar
      tbrMain.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));
      // Add Click event handler for each button in the Help toolbar
      tbrHelp.AddHandler(Button.ClickEvent, new RoutedEventHandler(Button_Click));
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Button btn;

      btn = (Button)e.OriginalSource;      
      switch (btn.Tag.ToString())
      {
        case "New":
          MessageBox.Show("New");
          break;
        case "Save":
          MessageBox.Show("Save");
          break;
        case "Delete":
          MessageBox.Show("Delete");
          break;
        case "Explore":
          MessageBox.Show("Explore");
          break;
        case "Help":
          MessageBox.Show("Help");
          break;
        default:
          MessageBox.Show(btn.Tag.ToString());
          break;
      }
    }
  }
}
