using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RxTicketsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TicketDetail : Page
    {

        public Ticket Ticket { get; set; }


        public TicketDetail()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Ticket ticket = e.Parameter as Ticket;
            BindPage(ticket);
        }



        public Visibility IsTicketCloseable
        {
            get
            {
                if( this.Ticket.Status == TicketStatus.Resolved || this.Ticket.Status == TicketStatus.InProcess)
                {
                    return Visibility.Visible;
                }
                return Visibility.Collapsed;
            }
        }

        public Visibility CanAddInteraction
        {
            get
            {
                if (this.Ticket.Status != TicketStatus.Closed)
                {
                    return Visibility.Visible;
                }
                return Visibility.Collapsed;
            }
        }

        private void AppBarButtonAddInteraction_Click(object sender, RoutedEventArgs e)
        {
            // Show add comment popup
            if (!AddInteractionPopup.IsOpen) { AddInteractionPopup.IsOpen = true; }
        }

        private void AddCommentButton_Click(object sender, RoutedEventArgs e)
        {
            // Add the comment
            var ticket = App.TicketService.AddInteraction(this.Ticket.TicketId, textComment.Text);            
            if (AddInteractionPopup.IsOpen) { AddInteractionPopup.IsOpen = false; }
            textComment.Text = String.Empty;
            BindPage(ticket);
        }

        private void BindPage(Ticket ticket)
        {
            this.Ticket = ticket;
            this.DataContext = this.Ticket;
            this.interactions.ItemsSource = this.Ticket.Interactions.OrderBy(x=>x.CreatedDate);
        }
    }
}
