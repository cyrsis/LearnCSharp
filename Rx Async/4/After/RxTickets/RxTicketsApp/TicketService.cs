using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTicketsApp
{
    public class TicketService
    {


        public async Task<List<Ticket>> GetTicketsFromServer()
        {
            List<Ticket> result = new List<Ticket>();

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(App.BaseUri); // sends GET request 
                result = JsonConvert.DeserializeObject<List<Ticket>>(response);
            }
            return result;
        }

        public async Task<List<Ticket>> SearchTicketsFromServer(string searchText, bool includeClosed)
        {
            List<Ticket> result = new List<Ticket>();
            var urlToAddInteraction = String.IsNullOrEmpty(searchText) ? 
                                        App.BaseUri.ToString() :
                                        String.Format("{0}/search/{1}", App.BaseUri, searchText);

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(urlToAddInteraction);
                result = JsonConvert.DeserializeObject<List<Ticket>>(response);
            }
            return result
                .Where(t => includeClosed || t.Status != TicketStatus.Closed)
                .ToList();
        }

        public async Task<Ticket> AddInteraction(int ticketId, string text)
        {
            Ticket result = null;
            using (var client = new HttpClient())
            {
                var urlToAddInteraction = String.Format("{0}/{1}/interaction", App.BaseUri, ticketId);
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("", text)
                });
                var message = await client.PostAsync(urlToAddInteraction, content);
                var messageContent = await message.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Ticket>(messageContent);
            }
            return result;
        }

        public async Task<int> CreateTicket(TicketDetails ticketDetails)
        {
            using (var client = new HttpClient())
            {
                var urlToAddTicket = App.BaseUri.ToString();
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("Title", ticketDetails.Title),
                    new KeyValuePair<string, string>("Category", ticketDetails.Category.ToString()),
                    new KeyValuePair<string, string>("Description", ticketDetails.Description),
                    new KeyValuePair<string, string>("Severity", ticketDetails.Severity.ToString())
                });
                var message = await client.PostAsync(urlToAddTicket, content);

            }
            return await Task.FromResult<int>(0);
        }

        public async Task<DateTime> GetTimestamp()
        {
            using (var client = new HttpClient())
            {
                var urlToTimestamp = String.Format("{0}/timestamp", App.BaseUri);
                var message = await client.GetStringAsync(urlToTimestamp);
                return JsonConvert.DeserializeObject<DateTime>(message);
            }
        }
    }
}
