
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DataLayerInterfaces;
using SalesModel.DomainClasses;
using System.Linq;

namespace SalesModel.DataLayer
{
  public class SalesModelContext : DbContext, ISalesModelContext
  {
    public IDbSet<Customer> Customers { get; set; }
    public IDbSet<Order> Orders { get; set; }
    public IDbSet<LineItem> LineItems { get; set; }
    public IDbSet<Address> Addresses { get; set; }
    public IDbSet<Product> Products { get; set; }
    

    public override int SaveChanges()
    {
      foreach (var stateinfo in this.ChangeTracker.Entries()
               .Where(e =>e.Entity is StateInfo  && ( e.State == EntityState.Added ||
                       e.State == EntityState.Modified))
                .Select(e=>e.Entity as StateInfo)
               )
      {
        stateinfo.ModifiedDate = DateTime.Now;
      }
      int result= base.SaveChanges();
      foreach (var stateinfo in this.ChangeTracker.Entries()
                                    .Where(e => e.Entity is StateInfo)
                                    .Select(e => e.Entity as StateInfo)
        )
      {
        stateinfo.IsDirty = false;
      }
      return result;
    }
    
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add(new ContactDetailMappings());
      modelBuilder.Ignore<Category>();
      base.OnModelCreating(modelBuilder);
    }
 
  }

  public class ContactDetailMappings : EntityTypeConfiguration<ContactDetail>
  {
    public ContactDetailMappings()
    {
      this.HasKey(c => c.CustomerId);
      Property(c => c.MobilePhone).HasColumnName("CellPhone");
      Property(c => c.HomePhone).HasMaxLength(20);
      HasRequired(c => c.Customer).WithRequiredDependent(cu => cu.ContactDetail).WillCascadeOnDelete(true);
    }
  }
  

}
