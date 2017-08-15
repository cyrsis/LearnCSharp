using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTicketsApp
{
    public class Interaction
    {
        public int TicketId { get; set; } // TicketId
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedDateForView { get { return this.CreatedDate.ToString("dd/MM/yyyy"); } }

        public string Text { get; set; } // Text (length: 2147483647)
        public string Author { get; set; } // Author (length: 50)

    }
}
