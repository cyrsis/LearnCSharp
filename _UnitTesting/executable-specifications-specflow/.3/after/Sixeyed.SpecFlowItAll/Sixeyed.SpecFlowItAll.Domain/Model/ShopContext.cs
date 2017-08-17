using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Sixeyed.SpecFlowItAll.Domain.Model.Mapping;

namespace Sixeyed.SpecFlowItAll.Domain.Model
{
    public partial class ShopContext : DbContext
    {
        static ShopContext()
        {
            Database.SetInitializer<ShopContext>(null);
        }

        public ShopContext()
            : base("Name=ShopContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new SupplierMap());
        }
    }
}
