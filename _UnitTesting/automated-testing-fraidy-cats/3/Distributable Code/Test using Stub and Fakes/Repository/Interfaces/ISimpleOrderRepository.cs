using System.Collections.Generic;
using SalesModel.DomainClasses;

namespace Repository
{
  public interface ISimpleOrderRepository:ISimpleRepository<Order>
  {
    List<Order> OrdersViaPromotion(SalesPromotion promo);
  }
}