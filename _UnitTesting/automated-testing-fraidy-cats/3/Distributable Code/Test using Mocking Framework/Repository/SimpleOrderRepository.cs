using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataLayerInterfaces;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;


namespace Repository
{
  public class SimpleOrderRepository: ISimpleOrderRepository
  {
    private ISalesModelContext _context ;

    public SimpleOrderRepository()
    {
      _context = new SalesModelContext();
    }

    public SimpleOrderRepository(ISalesModelContext context)
    {
      _context = context;
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    public IQueryable<Order> Get()
    {
      return _context.Orders;
    }

    public Order GetById(int id)
    {
      return _context.Orders.Find(id);
    }
   
    public List<Order> OrdersViaPromotion(SalesPromotion promo)
    {
      if (promo.StartDate <= DateTime.Today)
      {
        return _context.Orders.Where(o => o.PromotionId == promo.Id).ToList();
      }
      return null;
    }

    public void Add(Order entity)
    {
      _context.Orders.Add(entity);
    }

    public void Update(Order entity)
    {
      _context.Entry(entity).State = EntityState.Modified;
    }

  
    public void Delete(int id)
    {
      var order = _context.Orders.Find(id);
      _context.Orders.Remove(order);
    }

    public void Dispose()
    {
      _context.Dispose();
    }
    public bool IsValid(Order order)
    {

      var isValid= _context.Entry(order).GetValidationResult().IsValid;
      if (isValid)
      {
        var anyInValid = order.LineItems.Any(item => LineItemIsValid(item) == false);
        if (anyInValid)
          isValid = false;
      }
      return isValid;
    }

    public void SetContext(ISalesModelContext context)
    {
      _context = context;
    }

    private bool LineItemIsValid(LineItem lineItem)
    {
      var result = _context.Entry(lineItem).GetValidationResult();
      return result.IsValid;
    }

  

  }
}
