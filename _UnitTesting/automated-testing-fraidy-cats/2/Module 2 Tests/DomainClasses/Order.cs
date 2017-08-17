using System;
using System.Collections.Generic;
using System.Data.Spatial; //Using DbGeography requires System.Data.Entity assembly
using SalesModel.DomainClasses.Enums;

namespace SalesModel.DomainClasses
{
  public class Order : StateInfo
  {
    private ICollection<LineItem> _lineItems;

    public Order()
    {
      OrderDate = DateTime.Now.Date;
      _lineItems = new List<LineItem>();
    }

    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DbGeography DestinationLatLong { get; set; }
    public OrderSource OrderSource { get; set; }
    public int CustomerId { get; set; }
    

    public Customer Customer { get; set; }

    public ICollection<LineItem> LineItems
    {
      get { return _lineItems; }
      set { _lineItems = value; }
    }
  }
}