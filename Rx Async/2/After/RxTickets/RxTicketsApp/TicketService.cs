using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task<List<Ticket>> SearchTicketsFromServer(string searchText)
        {
            List<Ticket> result = new List<Ticket>();
            var urlToAddInteraction = String.Format("{0}/search/{1}", App.BaseUri, searchText);

            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(urlToAddInteraction); 
                result = JsonConvert.DeserializeObject<List<Ticket>>(response);
            }
            return result;
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
    }
}
