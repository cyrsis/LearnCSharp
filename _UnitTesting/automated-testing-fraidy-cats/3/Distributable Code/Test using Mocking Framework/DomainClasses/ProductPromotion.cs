using System;

namespace SalesModel.DomainClasses
{
  public class SalesPromotion
  {
    public int Id { get; set; }
    public string PromotionName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int PercentDiscount { get; set; }
  }
}
