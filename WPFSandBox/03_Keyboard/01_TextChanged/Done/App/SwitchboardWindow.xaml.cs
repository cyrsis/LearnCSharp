using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CoursewareApp {
  /// <summary>
  /// Interaction logic for SwitchboardWindow.xaml
  /// </summary>
  public partial class SwitchboardWindow : Window {
    public SwitchboardWindow() {
      InitializeComponent();
    }

   

    private void SuppressButton_Click(object sender, RoutedEventArgs e) {
      (new MainWindow()).Show();
    }

    private void ButtonExample_Click(object sender, RoutedEventArgs e) {
      (new UseArgs()).Show();
    }
  }
}
