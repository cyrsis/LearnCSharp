using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTicketsApp.Commands
{
    public class TicketDetailsCommand: AppCommand
    {
        public Ticket Ticket { get; private set; }

        public TicketDetailsCommand(Ticket ticket): base()
        {
            this.Ticket = ticket;
        }
    }
}
