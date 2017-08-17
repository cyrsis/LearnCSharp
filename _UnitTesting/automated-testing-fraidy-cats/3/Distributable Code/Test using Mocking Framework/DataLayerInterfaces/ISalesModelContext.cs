using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SalesModel.DomainClasses;

namespace DataLayerInterfaces
{
  public interface ISalesModelContext
  {
    IDbSet<Customer> Customers { get; set; }
    IDbSet<Order> Orders { get; set; }
    IDbSet<LineItem> LineItems { get; set; }
    IDbSet<Address> Addresses { get; set; }
    IDbSet<Product> Products { get; set; }
    DbEntityEntry Entry(object entity);
    int SaveChanges();
   
    void Dispose();
  }
}