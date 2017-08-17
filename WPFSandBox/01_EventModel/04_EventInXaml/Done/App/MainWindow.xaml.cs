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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursewareApp {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();

    }


    // 1. Create a method with correct signature
    //    this is the event handler method
    public void MouseHandler(object sender, MouseButtonEventArgs m) {
      // react to mouse down here
      if (m.ChangedButton == MouseButton.Left)
      {
        theTransform.AngleX += 2;
      }

      if (m.ChangedButton == MouseButton.Right)
      {
        theTransform.AngleY -= 2;
      }
    }

    private void foodImage_MouseUp(object sender, MouseButtonEventArgs e) {

    }
  }
}
