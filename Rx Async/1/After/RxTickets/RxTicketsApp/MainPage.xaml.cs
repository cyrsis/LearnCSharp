using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
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

namespace RxTicketsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var throttledSequence = Observable.FromEventPattern(searchTextBox, "TextChanged")
                .Select(x => ((TextBox) x.Sender).Text)
                .Where(x => x.Length >= 2)
                .Throttle(TimeSpan.FromMilliseconds(300))
                .DistinctUntilChanged();

            var results = throttledSequence
                .Select(t => App.TicketService.SearchTicketsFromServer(t))
                .ObserveOn(SynchronizationContext.Current);

            results.Subscribe(tickets=> 
            {
                BindTickets(tickets);
            });
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var tickets = App.TicketService.GetTicketsFromServer();
            BindTickets(tickets);
        }

        private void BindTickets(IEnumerable<Ticket> tickets)
        {
            gridView.ItemsSource = null;
            gridView.ItemsSource = tickets;
        }

        private void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Navigate to ticket detail screen
            var ticket = e.ClickedItem as Ticket;
            Frame.Navigate(typeof(TicketDetail), ticket);          
        }

    }
}
