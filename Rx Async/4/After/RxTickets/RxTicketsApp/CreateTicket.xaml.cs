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
    public sealed partial class CreateTicket : Page
    {
        public CreateTicket()
        {
            this.InitializeComponent();

            this.comboCategory.ItemsSource = Enum.GetValues(typeof (TicketCategory));
            this.comboSeverity.ItemsSource = Enum.GetValues(typeof (TicketSeverity));
        }

        private void CancelAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            GoBack();
        }
        private async void AcceptAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            TicketDetails ticketDetails = new TicketDetails();
            ticketDetails.Category = (int)this.comboCategory.SelectedItem;
            ticketDetails.Severity = (int)this.comboSeverity.SelectedItem;
            ticketDetails.Title = textTitle.Text;
            ticketDetails.Description = textDescription.Text;

            var ticketid = await App.TicketService.CreateTicket(ticketDetails);

            GoBack();
        }

        private static void GoBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }
    }
}
