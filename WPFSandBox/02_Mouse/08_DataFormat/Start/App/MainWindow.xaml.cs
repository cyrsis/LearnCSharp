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



   
    private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
      TextBlock tb = e.Source as TextBlock;

      var dragData = new DataObject(typeof(string), tb.Text);
      DragDrop.DoDragDrop(dragSource: tb,
                          data: dragData,
                          allowedEffects: DragDropEffects.Copy);
    }


    private SolidColorBrush _currentTextColor;
    private void TextBlock_DragEnter(object sender, DragEventArgs e) {
      var currentTextBlock = sender as TextBlock;

      scoreTextBlock.Text = "Guessing...";
      currentTextBlock.Foreground = new SolidColorBrush(Colors.Gold);
    }

    private void TextBlock_DragLeave(object sender, DragEventArgs e) {
      var currentTextBlock = sender as TextBlock;
      currentTextBlock.Foreground = new SolidColorBrush(Colors.White);
      scoreTextBlock.Text = "...Score...";
    }

    private void TextBlock_Drop(object sender, DragEventArgs e) {
      var currentTextBlock = sender as TextBlock;
      currentTextBlock.Foreground = new SolidColorBrush(Colors.White);
      string draggedWord = e.Data.GetData(typeof(string)) as string;
      scoreTextBlock.Text = "Try again.";
      if (draggedWord == "hot" && currentTextBlock.Text == "cold")
      {
        scoreTextBlock.Text = "Correct!";
      }
      

      if (draggedWord == "light" && currentTextBlock.Text == "heavy")
      {
        scoreTextBlock.Text = "Correct!";
      }
      

      if (draggedWord == "dry" && currentTextBlock.Text == "wet")
      {
        scoreTextBlock.Text = "Correct!";
      }
     

    }
   
  }
}
