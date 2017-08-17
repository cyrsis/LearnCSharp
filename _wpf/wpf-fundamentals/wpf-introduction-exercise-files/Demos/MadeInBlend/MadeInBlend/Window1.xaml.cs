using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;

namespace MadeInBlend
{
	public partial class Window1
	{
		public Window1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            myButton.Content = "Please do not click this again!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

	}
}