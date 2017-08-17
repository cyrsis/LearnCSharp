using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFComponents
{
  partial class AdvWorksDataContext
  {
    public IOrderedQueryable<Customer> GetAllCustomers()
    {
      var items = from cust in this.Customers
                  orderby cust.LastName
                  select cust;

      return items;
    }

    public IEnumerable<Customer> GetAllCustomersAsList()
    {
      var items = from cust in this.Customers
                  orderby cust.LastName
                  select cust;

      return items.ToList();
    }
  }
}
