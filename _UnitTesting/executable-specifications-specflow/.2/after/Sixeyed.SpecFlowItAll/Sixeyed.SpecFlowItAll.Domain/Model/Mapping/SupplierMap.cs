using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Sixeyed.SpecFlowItAll.Domain.Model.Mapping
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            // Primary Key
            this.HasKey(t => t.SupplierId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ReorderAddress)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Suppliers");
            this.Property(t => t.SupplierId).HasColumnName("SupplierId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ReorderType).HasColumnName("ReorderType");
            this.Property(t => t.ReorderAddress).HasColumnName("ReorderAddress");
        }
    }
}
