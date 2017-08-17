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
      //foodImage.MouseUp += Image_MouseUp;

      foodImage.AddHandler(MouseUpEvent,new MouseButtonEventHandler (FoodImage_MouseUp),false);

    }

   

    public void FoodImage_MouseUp(object sender, MouseButtonEventArgs e) {
      
      if (e.ChangedButton == MouseButton.Left)
      {
        theTransform.AngleX += 2;
      }

      if (e.ChangedButton == MouseButton.Right)
      {
        theTransform.AngleY -= 2;
      }
    }

   
  }
}
