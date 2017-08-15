using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTickets.Data
{
    public interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Interaction> Interactions { get; set; } // Interactions
        System.Data.Entity.DbSet<Ticket> Tickets { get; set; } // Tickets
        System.Data.Entity.DbSet<TimestampRow> Timestamp { get; set; } // Tickets

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }
}
