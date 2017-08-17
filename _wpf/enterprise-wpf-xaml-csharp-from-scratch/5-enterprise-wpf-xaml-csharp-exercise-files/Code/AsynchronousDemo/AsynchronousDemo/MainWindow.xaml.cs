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

namespace AsynchronousDemo
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
         ComputeStuffAsync();
      }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( "Button clicked!" );
      }

      private async void ComputeStuffAsync()
      {
         for (;;)
         {
            var sum = 0.0;
            Message.Text = "Computing...";
            await Task.Run( () =>
            {
               for ( int i = 1; i < 200000000; i++ )  //two hundred million iterations
               {
                  sum += Math.Sqrt( i );
               }
            } );
            Message.Text = "Sum = " + sum;
            await Task.Run( () =>
            {
               for ( int i = 1; i < 200000000; i++ )  //two hundred million iterations
               {
                  sum += Math.Sqrt( i );
               }
            } );
            Message.Text = "Sum = " + sum;
           await Task.Run( () =>
            {
               for ( int i = 1; i < 200000000; i++ )  //two hundred million iterations
               {
                  sum += Math.Sqrt( i );
               }
            } );
            Message.Text = "Sum = " + sum;
            await Task.Run( () =>
            {
               for ( int i = 1; i < 200000000; i++ )  //two hundred million iterations
               {
                  sum += Math.Sqrt( i );
               }
            } );
            Message.Text = "Sum = " + sum;
         }
      }
   }
}
