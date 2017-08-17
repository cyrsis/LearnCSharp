using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;


namespace Repository
{
  public class SimpleOrderRepository:IDisposable
  {
    readonly SalesModelContext _context = new SalesModelContext();

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
      _context.Entry(order).State = EntityState.Modified;
  
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

      var isValid= _context.Entry(order).GetValidationResult().IsValid;
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
      var result = _context.Entry(lineItem).GetValidationResult();
      return result.IsValid;
    }
  }
}
