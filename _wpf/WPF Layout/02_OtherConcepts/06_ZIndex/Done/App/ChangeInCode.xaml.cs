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
	/// Interaction logic for ChangeInCode.xaml
	/// </summary>
	public partial class ChangeInCode : Window {
		public ChangeInCode() {
			InitializeComponent();
		}

		private void LetterBoxA_MouseUp(object sender, MouseButtonEventArgs e) {
			Panel.SetZIndex(LetterBoxA, Panel.GetZIndex(LetterBoxD) + 1);
		}

		private void LetterBoxD_MouseUp(object sender, MouseButtonEventArgs e) {
			Panel.SetZIndex(LetterBoxD, Panel.GetZIndex(LetterBoxA) + 1);
		}
	}
}
