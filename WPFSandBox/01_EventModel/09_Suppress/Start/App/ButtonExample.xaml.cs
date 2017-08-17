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
using System.Windows.Threading;

namespace CoursewareApp {
  /// <summary>
  /// Interaction logic for ButtonExample.xaml
  /// </summary>
  public partial class ButtonExample : Window {
    public ButtonExample() {
      InitializeComponent();

      _timer.Interval = TimeSpan.FromSeconds(2);
      _timer.Start();
      _timer.Tick += Timer_Tick;
    }


    private int _tunnelCounter = 0;
    private int _bubbleCounter = 0;
    private DispatcherTimer _timer = new DispatcherTimer();

    private void Timer_Tick(object sender, EventArgs e) {
      _tunnelCounter = 0;
      _bubbleCounter = 0;
    }

    private void All_MouseUp(object sender, MouseButtonEventArgs e) {
      _bubbleCounter += 1;
      this.messageListBox.Items.Add(string.Format($"Bubble {_bubbleCounter} ({e.ChangedButton} mouse): {sender.GetType().Name}"));
    }

    private void All_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
      _tunnelCounter += 1;
      this.messageListBox.Items.Add(string.Format($"Tunnel {_tunnelCounter} ({e.ChangedButton} mouse): {sender.GetType().Name}"));
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      this.messageListBox.Items.Add(string.Format($"Click : {sender.GetType().Name}"));

    }

    private void ClearButton_Click(object sender, RoutedEventArgs e) {
      messageListBox.Items.Clear();
    }
  }
}
