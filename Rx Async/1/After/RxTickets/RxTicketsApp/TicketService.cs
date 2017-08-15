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


        public List<Ticket> GetTicketsFromServer()
        {
            List<Ticket> result = new List<Ticket>();

            using (var client = new HttpClient())
            {
                var response = "";
                Task task = Task.Run(async () =>
                {
                    response = await client.GetStringAsync(App.BaseUri); // sends GET request 
                });
                task.Wait(); // Wait 
                result = JsonConvert.DeserializeObject<List<Ticket>>(response);
            }
            return result;
        }

        public List<Ticket> SearchTicketsFromServer(string searchText)
        {
            List<Ticket> result = new List<Ticket>();
            var urlToAddInteraction = String.Format("{0}/search/{1}", App.BaseUri, searchText);

            using (var client = new HttpClient())
            {
                var response = "";
                Task task = Task.Run(async () =>
                {
                    response = await client.GetStringAsync(urlToAddInteraction); 
                });
                task.Wait();  
                result = JsonConvert.DeserializeObject<List<Ticket>>(response);
            }
            return result;
        }

        public Ticket AddInteraction(int ticketId, string text)
        {
            Ticket result = null;
            using (var client = new HttpClient())
            {
                var messageContent = "";

                Task task = Task.Run(async () =>
                {
                    var urlToAddInteraction = String.Format("{0}/{1}/interaction", App.BaseUri, ticketId);
                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("", text)
                    });
                    var message = await client.PostAsync(urlToAddInteraction, content);
                    messageContent = await message.Content.ReadAsStringAsync();
                });
                task.Wait(); // Wait 
                result = JsonConvert.DeserializeObject<Ticket>(messageContent);
            }
            return result;
        }
    }
}
