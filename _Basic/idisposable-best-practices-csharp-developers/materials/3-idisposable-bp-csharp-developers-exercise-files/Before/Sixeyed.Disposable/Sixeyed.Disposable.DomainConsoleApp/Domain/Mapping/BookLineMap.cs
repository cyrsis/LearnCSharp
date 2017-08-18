using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;

namespace Sixeyed.Disposable.DomainConsoleApp.Domain.Mapping
{
    public class BookLineMap : EntityTypeConfiguration<BookLine>
    {
        public BookLineMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Excerpt)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BookLine");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BookFeedId).HasColumnName("BookFeedId");
            this.Property(t => t.LineNumber).HasColumnName("LineNumber");
            this.Property(t => t.WordCount).HasColumnName("WordCount");
            this.Property(t => t.Excerpt).HasColumnName("Excerpt");

            // Relationships
            this.HasRequired(t => t.BookFeed)
                .WithMany(t => t.BookLines)
                .HasForeignKey(d => d.BookFeedId);
        }
    }
}
