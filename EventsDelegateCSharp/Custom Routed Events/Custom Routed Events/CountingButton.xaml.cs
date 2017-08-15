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

namespace Custom_Routed_Events
{
    /// <summary>
    /// Interaction logic for CountingButton.xaml
    /// </summary>
    public partial class CountingButton : UserControl
    {
        public CountingButton()
        {
            InitializeComponent();
        }

        // Register the tunneling PreviewIncrement event.
        public static readonly RoutedEvent PreviewIncrementEvent =
            EventManager.RegisterRoutedEvent("PreviewIncrement",
                RoutingStrategy.Tunnel,
                typeof(RoutedEventHandler),
                typeof(CountingButton));

        // Register the bubbling Increment event.
        public static readonly RoutedEvent IncrementEvent =
            EventManager.RegisterRoutedEvent("Increment",
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(CountingButton));

        // Event accessors for PreviewIncrement.
        public event RoutedEventHandler PreviewIncrement
        {
            add { AddHandler(PreviewIncrementEvent, value); }
            remove { RemoveHandler(PreviewIncrementEvent, value); }
        }

        // Event accessors for Increment.
        public event RoutedEventHandler Increment
        {
            add { AddHandler(IncrementEvent, value); }
            remove { RemoveHandler(IncrementEvent, value); }
        }

        // Raise the PreviewIncrement event.
        protected virtual void OnPreviewIncrement()
        {
            RoutedEventArgs args =
                new RoutedEventArgs(PreviewIncrementEvent);
            RaiseEvent(args);
        }

        // Raise the Increment event.
        protected virtual void OnIncrement()
        {
            RoutedEventArgs args =
                new RoutedEventArgs(IncrementEvent);
            RaiseEvent(args);
        }

        private int Count = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            OnPreviewIncrement();

            Count++;
            countLabel.Content = "Click " + Count;

            OnIncrement();
        }
    }
}
