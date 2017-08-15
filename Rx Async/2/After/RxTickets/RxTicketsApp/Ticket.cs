using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RxTicketsApp
{
    public enum TicketSeverity
    {
        Low = 1,
        Normal = 0,
        High = 2,
        Critical = 3
    }

    public enum TicketCategory
    {
        Hardware = 0,
        Software = 1,
        Access = 2
    }

    public enum TicketStatus
    {
        Created = 0,
        InProcess = 1,
        Resolved = 2,
        Closed = 3
    }

    public class Ticket
    {
        public int TicketId { get; set; } // TicketId (Primary key)
        public TicketSeverity Severity { get; set; } // Severity
        public TicketCategory Category { get; set; } // Category
        public string Title { get; set; } // Title
        public string Author { get; set; } // Author (length: 50)
        public System.DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedDateForView { get { return this.CreatedDate.ToString("dd/MM/yyyy"); } }
        public System.DateTime? ResolvedDate { get; set; } // ResolvedDate
        public TicketStatus Status { get; set; } // Status

        // Reverse navigation
        public System.Collections.Generic.ICollection<Interaction> Interactions { get; set; } 

        public Windows.UI.Xaml.Media.SolidColorBrush StatusBrush
        {
            get
            {
                Windows.UI.Color result = Windows.UI.Colors.Gray;

                switch(this.Status)
                {
                    case TicketStatus.Resolved:
                        result = Windows.UI.Colors.Green;
                        break;
                    case TicketStatus.Created:
                        result = Windows.UI.Colors.Red;
                        break;
                    case TicketStatus.InProcess:
                        result = Windows.UI.Colors.Orange;
                        break;
                    default:
                        break;
                }
                return new Windows.UI.Xaml.Media.SolidColorBrush(result);
            }
        }


    }
}
