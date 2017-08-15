using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RxTickets.Data
{
    public class TicketsRepository
    {
        private IMyDbContext _ctx;

        public TicketsRepository()
        {
            _ctx = new MyDbContext();
        }

        public IEnumerable<Ticket> GetTickets()
        {
            var tickets = _ctx.Tickets
                            .Include(t => t.Interactions)
                            .AsEnumerable();
            return tickets;
        }

        public IEnumerable<Ticket> SearchTickets(string searchTerm)
        {
            var tickets = _ctx.Tickets
                            .Include(t => t.Interactions)
                            .AsEnumerable()
                            .Where(t => t.Title.ToLowerInvariant().Contains(searchTerm));
            return tickets;
        }

        public Ticket GetTicket(int ticketId)
        {
            var ticket = _ctx.Tickets
                .Where(w => w.TicketId == ticketId)
                .Include(t => t.Interactions)
                .SingleOrDefault();

            return ticket;
        }

        public Ticket AddInteractionToTicket(int ticketId, Interaction interaction)
        {
            var ticket = _ctx.Tickets.Find(ticketId);
            ticket.Interactions.Add(interaction);
            _ctx.SaveChanges();
            return ticket;     
        }

    }
}
