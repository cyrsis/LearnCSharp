using System.Linq;
using SalesModel.DomainClasses;

namespace FakesForTesting
{
  public class FakeOrderDbSet : FakeDbSet<Order> 
  {  public override Order Find(params object[] keyValues)
  {
    var keyValue = (int)keyValues.FirstOrDefault();
    return this.SingleOrDefault(o=>o.OrderId == keyValue);
  }
  }
}