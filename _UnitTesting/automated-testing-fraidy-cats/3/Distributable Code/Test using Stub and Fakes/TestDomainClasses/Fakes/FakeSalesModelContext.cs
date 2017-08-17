using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FakesForTesting;
using SalesModel.DomainClasses;

namespace DataLayerInterfaces
{
  class FakeSalesModelContext : ISalesModelContext
  {  
    public FakeSalesModelContext()
    {
        Orders= new FakeOrderDbSet();
    }
    public IDbSet<Customer> Customers { get; set; }
    public IDbSet<Order> Orders { get; set; }
    public IDbSet<LineItem> LineItems { get; set; }
    public IDbSet<Address> Addresses { get; set; }
    public IDbSet<Product> Products { get; set; }
    public DbEntityEntry Entry(object entity)
    {
      throw new System.NotImplementedException();
    }

    public int SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void Dispose()
    {
      
    }
  }
}