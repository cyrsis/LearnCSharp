
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Validation;
using DataLayerInterfaces;
using SalesModel.DomainClasses;
using System.Linq;

namespace SalesModel.DataLayer
{
  public class SalesModelContext : DbContext,ISalesModelContext
  {
    public IDbSet<Customer> Customers { get; set; }
    public IDbSet<Order> Orders { get; set; }
    public IDbSet<LineItem> LineItems { get; set; }
    public IDbSet<Address> Addresses { get; set; }
    public IDbSet<Product> Products { get; set; }
    
 
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
