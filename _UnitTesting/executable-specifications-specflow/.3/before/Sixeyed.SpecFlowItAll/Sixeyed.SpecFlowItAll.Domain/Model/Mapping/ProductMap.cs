using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sixeyed.SpecFlowItAll.Domain.Model.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.StockCount).HasColumnName("StockCount");
            this.Property(t => t.IsAvailable).HasColumnName("IsAvailable");

            // Relationships
            this.HasRequired(t => t.Supplier)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.SupplierId);

        }
    }
}
