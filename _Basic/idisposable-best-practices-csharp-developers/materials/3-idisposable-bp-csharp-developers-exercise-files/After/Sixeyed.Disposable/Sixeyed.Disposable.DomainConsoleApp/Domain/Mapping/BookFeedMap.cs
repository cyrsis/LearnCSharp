using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;

namespace Sixeyed.Disposable.DomainConsoleApp.Domain.Mapping
{
    public class BookFeedMap : EntityTypeConfiguration<BookFeed>
    {
        public BookFeedMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Path)
                .IsRequired()
                .HasMaxLength(512);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("BookFeed");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Path).HasColumnName("Path");
            this.Property(t => t.LineCount).HasColumnName("LineCount");
            this.Property(t => t.WordCount).HasColumnName("WordCount");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ProcessingMilliseconds).HasColumnName("ProcessingMilliseconds");
        }
    }
}
