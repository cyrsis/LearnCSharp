using RxTickets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RxTickets.Service.Controllers
{
    public class TicketsController : ApiController
    {
        private TicketsRepository _repository;

        public TicketsController()
        {
            this._repository = new TicketsRepository();
        }
        // GET api/tickets
        public IEnumerable<Ticket> Get()
        {
            var tickets = this._repository.GetTickets();
            return tickets;
        }

        [HttpGet]
        [Route("api/tickets/search/{searchText}")]
        public IEnumerable<Ticket> Search(string searchText)
        {
            var tickets = this._repository.SearchTickets(searchText);
            return tickets;
        }

        // GET api/tickets/5
        public Ticket Get(int id)
        {
            var ticket = this._repository.GetTicket(id);
            return ticket;
        }

        [HttpPost]
        [Route("api/tickets/{id}/interaction")]
        public Ticket AddInteraction([FromBody] string text, int id)
        {
            var interaction = new Interaction();
            interaction.Author = "ekapic";
            interaction.CreatedDate = DateTime.Now;
            interaction.Text = text;

            var updatedTicket = this._repository.AddInteractionToTicket(id, interaction);
            return updatedTicket;
        }

        // POST api/tickets
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tickets/5
        public void Put(int id, [FromBody]string value)
        {
        }


    }
}
