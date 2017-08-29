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

namespace UseVisibility {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void Target_Loaded(object sender, RoutedEventArgs e) {

		}

		private void VisibleButton_Click(object sender, RoutedEventArgs e) {
			ChangeLetterBox1.Visibility = ChangeLetterBox2.Visibility = Visibility.Visible;
		}

		private void HiddenButton_Click(object sender, RoutedEventArgs e) {
			ChangeLetterBox1.Visibility = ChangeLetterBox2.Visibility = Visibility.Hidden;
		}

		private void CollapsedButton_Click(object sender, RoutedEventArgs e) {
			ChangeLetterBox1.Visibility = ChangeLetterBox2.Visibility = Visibility.Collapsed;
		}
	}
}
