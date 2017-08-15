using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTickets.Data
{
    public class InteractionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Interaction>
    {
        public InteractionConfiguration()
            : this("dbo")
        {
        }

        public InteractionConfiguration(string schema)
        {
            ToTable(schema + ".Interactions");
            HasKey(x => new { x.TicketId, x.CreatedDate, x.Text, x.Author });

            Property(x => x.TicketId).HasColumnName(@"TicketId").IsRequired().HasColumnType("int");
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.Text).HasColumnName(@"Text").IsRequired().IsUnicode(false).HasColumnType("text").HasMaxLength(2147483647);
            Property(x => x.Author).HasColumnName(@"Author").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);

        }
    }

    // Tickets
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.20.0.0")]
    public class TicketConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ticket>
    {
        public TicketConfiguration()
            : this("dbo")
        {
        }

        public TicketConfiguration(string schema)
        {
            ToTable(schema + ".Tickets");
            HasKey(x => x.TicketId);

            Property(x => x.TicketId).HasColumnName(@"TicketId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Severity).HasColumnName(@"Severity").IsRequired().HasColumnType("int");
            Property(x => x.Category).HasColumnName(@"Category").IsRequired().HasColumnType("int");
            Property(x => x.Title).HasColumnName(@"Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(75);
            Property(x => x.Author).HasColumnName(@"Author").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ResolvedDate).HasColumnName(@"ResolvedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.Status).HasColumnName(@"Status").IsRequired().HasColumnType("int");

            HasMany(x => x.Interactions).WithRequired(x => x.Ticket).HasForeignKey(x => x.TicketId);
        }
    }
}
