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
 
    public void VerboseMouseSignature(FrameworkElement sender,
                                      MouseButtonState leftButton,
                                      MouseButtonState middleButton,
                                      MouseButtonState rightButton,
                                      MouseButtonState altButton1,
                                      MouseButtonState altButton2,
                                      MouseDevice device,
                                      Point currentPosition) {

    }

    public void VerboseKeySignature(FrameworkElement sender,
                                    bool isDown,
                                    bool isRepeat,
                                    bool isToggled,
                                    bool isUp,
                                    Key whichKey,
                                    Key systemKey,
                                    KeyStates keyStates) {
    }

    public void DotNetEventSignature(object o, EventArgs e) {
    }

    public void WpfEventSignature(object o, RoutedEventArgs e) {
    }


    public void WpfTextSignature(object o, MouseEventArgs e) {
      
    }
    public void WpfTextSignature(object o, TextChangedEventArgs e) {
    }

  }
}
