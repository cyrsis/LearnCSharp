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
using System.Windows.Threading;

namespace CoursewareApp {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			_timer.Interval = TimeSpan.FromSeconds(2);
			_timer.Start();
			_timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e) {
			_tunnelCounter = 0;
			_bubbleCounter = 0;
		}

		private DispatcherTimer _timer = new DispatcherTimer();



		private int _tunnelCounter = 0;
		private int _bubbleCounter = 0;

		private void AllElements_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e) {

			_tunnelCounter += 1;
			this.messageList.Items.Add(string.Format($"Tunnel {_tunnelCounter}: {sender.GetType().Name}"));
			var currentBorder = (Border)this.FindName("mainBorder");
			if (suppressCheckBox.IsChecked.Value &&  sender == currentBorder )
			{
				e.Handled = true;
			}

		}

		private void AllElements_MouseRightButtonUp(object sender, MouseButtonEventArgs e) {
			_bubbleCounter += 1;
			this.messageList.Items.Add(string.Format($"Bubble {_bubbleCounter}: {sender.GetType().Name}"));
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			messageList.Items.Clear();
		}
	}
}
