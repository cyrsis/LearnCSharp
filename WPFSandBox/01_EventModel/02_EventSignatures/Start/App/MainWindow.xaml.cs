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

			var timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Start();
			timer.Tick += null;
		}

    // 1. Create a method with correct signature
    //    this is the event handler method
    private void TimerWrongSignature() {
      messageText.Text = DateTime.Now.ToString("hh:mm:ss");
    }

    private void TimerAnotherWrongSignature(string s) {
      messageText.Text = DateTime.Now.ToString("hh:mm:ss");
    }

    private void Timer_Tick(object o, EventArgs a) {
			messageText.Text = DateTime.Now.ToString("hh:mm:ss");
		}

    

	


		public void MouseHandler(object o, MouseEventArgs m) {
			// react to mouse down here

			scaleTransform.ScaleX = scaleTransform.ScaleY = 1.1;

		}
	

		
	}
}
