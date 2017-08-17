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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

		}

    Point _startPosition;
    private void Images_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
      _startPosition = e.GetPosition(null);
    }

    private void Images_MouseMove(object sender, MouseEventArgs e) {
      if (e.LeftButton == MouseButtonState.Pressed)
      {
        Point currentPosition = e.GetPosition(null);
        if (Math.Abs(_startPosition.X = currentPosition.X) > SystemParameters.MinimumHorizontalDragDistance ||
           Math.Abs(_startPosition.Y - currentPosition.Y) > SystemParameters.MinimumVerticalDragDistance)
        {
          Image image = e.Source as Image;

          var dragData = new DataObject(typeof(ImageSource), image.Source);
          DragDrop.DoDragDrop(dragSource: image,
                              data: dragData,
                              allowedEffects: DragDropEffects.Copy);
        }
      }
    }
  }
}
