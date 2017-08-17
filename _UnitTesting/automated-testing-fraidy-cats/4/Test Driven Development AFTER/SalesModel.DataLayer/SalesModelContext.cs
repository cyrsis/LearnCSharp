
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Validation;
using SalesModel.DomainClasses;
using System.Linq;

namespace SalesModel.DataLayer
{
  public interface ISalesModelContext
  {
    IDbSet<Customer> Customers { get; set; }
    IDbSet<Order> Orders { get; set; }
    IDbSet<LineItem> LineItems { get; set; }
    IDbSet<Address> Addresses { get; set; }
    IDbSet<Product> Products { get; set; }
    IDbSet<CancelledOrder> CancelledOrders { get; set; }
    int SaveChanges();
    void Dispose();
      
    void SetModified(object entity);
    DbEntityValidationResult GetValidationResult(object entity);
  }

 

  public class SalesModelContext : DbContext, ISalesModelContext
  {
    public IDbSet<Customer> Customers { get; set; }
    public IDbSet<Order> Orders { get; set; }
    public IDbSet<LineItem> LineItems { get; set; }
    public IDbSet<Address> Addresses { get; set; }
    public IDbSet<Product> Products { get; set; }
    public IDbSet<CancelledOrder> CancelledOrders { get; set; }

     


    public override int SaveChanges()
    {

      foreach (var entity in this.ChangeTracker.Entries()
               .Where(e => e.Entity is StateInfo)
               .Select(e => e.Entity as StateInfo))
      {
        var entry = Entry(entity);
        entry.State = StateHelpers.ConvertState(entity.State);
        if (entry.State == EntityState.Added ||
                       entry.State == EntityState.Modified)
        { entity.ModifiedDate = DateTime.Now; }
      }
      int result = base.SaveChanges();
      foreach (var entity in this.ChangeTracker.Entries()
                                    .Where(e => e.Entity is StateInfo)
                                    .Select(e => e.Entity as StateInfo)
        )
      {
        entity.IsDirty = false;

      }

      return result;
    }

    public void SetModified(object entity)
    {
      Entry(entity).State=EntityState.Modified;
    }

    public DbEntityValidationResult GetValidationResult(object entity)
    {
      return Entry(entity).GetValidationResult();
    }


    protected override DbEntityValidationResult ValidateEntity(System.Data.Entity.Infrastructure.DbEntityEntry entityEntry, IDictionary<object, object> items)
    {
      return base.ValidateEntity(entityEntry, items);
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
