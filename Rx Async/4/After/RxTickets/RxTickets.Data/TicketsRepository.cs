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

        public DateTime GetTimestamp()
        {
            var timestampRow = _ctx.Timestamp.First();
            return timestampRow.LastModified.Value;
        }

        public int CreateNewTicket(TicketDetails ticketDetails)
        {
            var newTicket = _ctx.Tickets.Create();
            newTicket.Author = "ekapic";
            newTicket.Category = ticketDetails.Category;
            newTicket.CreatedDate = DateTime.Now;
            newTicket.Status = 0;
            newTicket.Title = ticketDetails.Title;

            var newInteraction = new Interaction();
            newInteraction.Author = "ekapic";
            newInteraction.Text = ticketDetails.Description;
            newInteraction.CreatedDate = DateTime.Now;

            newTicket.Interactions = new List<Interaction>();
            newTicket.Interactions.Add(newInteraction);

            AddTimestamp(_ctx);
                    
            _ctx.Tickets.Add(newTicket);
            _ctx.SaveChanges();
            return newTicket.TicketId;
        }

        private void AddTimestamp(IMyDbContext _ctx)
        {
            var timestampExists = _ctx.Timestamp.Count() > 0;
            var timestampRow = _ctx.Timestamp.First();
            timestampRow.LastModified = DateTime.Now;
        }
    }
}
