using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;


namespace Repository
{
  public class SimpleOrderRepository : IDisposable
  {
    private readonly ISalesModelContext _context;
    public SimpleOrderRepository()
    {
      _context = new SalesModelContext();
    }


    public SimpleOrderRepository(ISalesModelContext context)
    {
      _context = context;
    }

    public IQueryable<Order> Orders()
    {
      return _context.Orders;
    }


    public void Save()
    {
      _context.SaveChanges();
    }

    public Order GetOrderById(int id)
    {
      return _context.Orders.Find(id);
    }

    public void AddNewOrder(Order order)
    {
      _context.Orders.Add(order);
    }

    public void UpdateOrder(Order order)
    {
      _context.SetModified(order);

    }


    public void DeleteOrder(int id)
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

      var isValid = _context.GetValidationResult(order).IsValid;
      if (isValid)
      {
        var anyInValid = order.LineItems.Any(item => LineItemIsValid(item) == false);
        if (anyInValid)
          isValid = false;
      }
      return isValid;
    }

    public List<Order> CachedOrders()
    {
      return _context.Orders.Local.ToList();
    }

    private bool LineItemIsValid(LineItem lineItem)
    {
      var result = _context.GetValidationResult(lineItem);
      return result.IsValid;
    }


    public void CancelOrder(int orderId, string reason)
    {
      //note, I chose not to simply use the existing
      //DeleteOrder method for this first call because
      //I want to leave myself open to add more logic to FindAndRemoveOrder
      //that may not coincide with DeleteOrder
      var order = FindAndRemoveOrder(orderId);
      CreateAndAddCancelledOrderFromOrder(reason, order);
    }

    public Order FindAndRemoveOrder(int orderId)
    {
      var order = _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
      _context.Orders.Remove(order);
      return order;
    }

    public void CreateAndAddCancelledOrderFromOrder(string reason, Order order)
    {
      _context.CancelledOrders.Add(new CancelledOrder
                                     {
                                       OriginalOrderId = order.OrderId,
                                       CustomerId = order.CustomerId,
                                       CancelledDate = DateTime.Now,
                                       Reason = reason
                                     });
    }

    public IQueryable<CancelledOrder> CancelledOrders()
    {
      return _context.CancelledOrders;
    }
  }


}
