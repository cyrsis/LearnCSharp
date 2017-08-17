using System;

namespace SalesModel.DomainClasses
{
  public class CancelledOrder
  {
    public int CancelledOrderId { get; set; }
    public string Reason { get; set; }

    public DateTime CancelledDate { get; set; }

    public int CustomerId { get; set; }
  }
}