using System;

namespace SalesModel.DomainClasses
{
  public class CancelledOrder:StateInfo
  {
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime CancelledDate { get; set; }
    public string Reason { get; set; }

    public int OriginalOrderId { get; set; }
 
  }
}