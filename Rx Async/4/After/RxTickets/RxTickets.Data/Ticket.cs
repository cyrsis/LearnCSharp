using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTickets.Data
{
    public class Ticket
    {
        public int TicketId { get; set; } // TicketId (Primary key)
        public int Severity { get; set; } // Severity
        public int Category { get; set; } // Category
        public string Title { get; set; } // Title
        public string Author { get; set; } // Author (length: 50)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public System.DateTime? ResolvedDate { get; set; } // ResolvedDate
        public int Status { get; set; } // Status

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Interaction> Interactions { get; set; } // Many to many mapping

        public Ticket()
        {
            Interactions = new System.Collections.Generic.List<Interaction>();
        }
    }
}
