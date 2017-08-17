using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using SalesModel.DomainClasses;
using SalesModel.DomainClasses.Enums;

namespace Repository
{
  public class FakeSimpleOrderRepository : ISimpleOrderRepository
  {
    private List<Order> _orders;

    public FakeSimpleOrderRepository()
    {
      _orders = new List<Order>();


      PopulateOrders();
    }

    private void PopulateOrders()
    {
      var product1 = new Product
                       {
                         ProductId = 1,
                         Name = "Product1",
                         Description = "A great product",
                         ProductionStart = new DateTime(2001, 1, 1)
                       };
      var product2 = new Product
                       {
                         ProductId = 2,
                         Name = "Product2",
                         Description = "Another great product",
                         ProductionStart = new DateTime(2002, 2, 2)
                       };
      var customer = new Customer
                       {
                         FirstName = "Julie",
                         LastName = "Lerman",
                         ContactDetail = new ContactDetail
                                           {
                                             TwitterAlias = "julielerman"
                                           },
                         DateOfBirth = DateTime.Now
                       };
      var order = new Order
                    {
                      DestinationLatLong = DbGeography.FromText("POINT(44.292401 -72.968102)"),
                      OrderDate = DateTime.Now,
                      OrderSource = OrderSource.InPerson,
                      PromotionId = 1
                    };
      
      order.LineItems =
        new List<LineItem>
          {
            new LineItem {Product = product1, Quantity = 2},
            new LineItem {Product = product2, Quantity = 1}
          };

      order.Customer = customer;
      _orders.Add(order);
    }


    public void Dispose()
    {
      
    }

    public void Save()
    {
      throw new System.NotImplementedException();
    }



    public IQueryable<Order> Get()
    {
      return _orders.AsQueryable();
    }

    public Order GetById(int id)
    {
      return _orders.FirstOrDefault(o => o.OrderId == id);
    }

    public void Add(Order entity)
    {
      _orders.Add(entity);
    }

    public void Update(Order entity)
    {
      _orders.Remove(entity);
      _orders.Add(entity);
    }

    public void Delete(int id)
    {
      var order=_orders.FirstOrDefault(o => o.OrderId == id);
      _orders.Remove(order);
    }

    public bool IsValid(Order entity)
    {
      throw new System.NotImplementedException();
    }

    public List<Order> OrdersViaPromotion(SalesPromotion promo)
    {
      return _orders.Where(o => o.PromotionId == promo.Id).ToList();
    }
  }
}