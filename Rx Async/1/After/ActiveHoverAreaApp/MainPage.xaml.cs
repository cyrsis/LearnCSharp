using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ActiveHoverAreaApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // Observable sequence of mouse moves
            var mouseSequence = Observable.FromEventPattern<PointerRoutedEventArgs>(this, "PointerMoved");
            
            // Observable sequence of out-of-area moves
            var outAreaSequence = mouseSequence.Where(x => x.EventArgs.GetCurrentPoint(null).Position.Y > 100);
            
            // Observable sequences of booleans: in and out of area, only when changed
            var changesSequence = mouseSequence
                .Select((x) => x.EventArgs.GetCurrentPoint(null).Position.Y < 100 ? true : false)
                .DistinctUntilChanged();

            // Trigger a 500ms countdown while the mouse is in the area
            // to show the button, but cancel it if the mouse leaves the area
            changesSequence
                .Where(x => x == true)
                .Select((x) =>
                   Observable.Timer(TimeSpan.FromMilliseconds(500))
                       .TakeUntil(outAreaSequence)
                       .ObserveOnDispatcher()
                       .Subscribe((val) => this.button.Visibility = Visibility.Visible)
                )
                .Subscribe((ii) => DoNothing()); // Dummy subscription to ensure values

            // Hide the button when the mouse moves out of the area
            changesSequence
                .Where(x=> x == false)
                .ObserveOnDispatcher()
                .Subscribe((x) => this.button.Visibility = Visibility.Collapsed);
        }

        private void DoNothing()
        {

        }
    }
}
