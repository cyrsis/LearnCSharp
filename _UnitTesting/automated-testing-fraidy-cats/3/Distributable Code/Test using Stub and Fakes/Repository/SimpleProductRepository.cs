using System;
using System.Data;
using System.Linq;
using DataLayerInterfaces;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;

namespace Repository
{
  class SimpleProductRepository : ISimpleRepository<Product>
  {
    readonly ISalesModelContext _context ;

    public SimpleProductRepository()
    {
        _context=new SalesModelContext();
    }

    public SimpleProductRepository(ISalesModelContext context)
    {
      _context = context;
    }

    public IQueryable<Product> Get()
    {
      return _context.Products;
    }

    public Product GetById(int id)
    {
      return _context.Products.Find(id);
    }

    public void Add(Product entity)
    {
      _context.Products.Add(entity);
    }

    public void Update(Product entity)
    {
      _context.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
      var product = _context.Products.Find(id);
      _context.Products.Remove(product);
    }
    

    public bool IsValid(Product entity)
    {
      throw new NotImplementedException();
    }
    public void Dispose()
    {
     
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}