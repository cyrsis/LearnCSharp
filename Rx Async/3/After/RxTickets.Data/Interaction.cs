using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTickets.Data
{
    public class Interaction
    {
        public int TicketId { get; set; } // TicketId
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public string Text { get; set; } // Text (length: 2147483647)
        public string Author { get; set; } // Author (length: 50)
        public virtual Ticket Ticket { get; set; } 

    }
}
