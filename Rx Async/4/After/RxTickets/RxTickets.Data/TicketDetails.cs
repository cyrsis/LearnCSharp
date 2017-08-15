using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTickets.Data
{
    public class TicketDetails
    {
        public string Title { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        public int Severity { get; set; }
    }
}
