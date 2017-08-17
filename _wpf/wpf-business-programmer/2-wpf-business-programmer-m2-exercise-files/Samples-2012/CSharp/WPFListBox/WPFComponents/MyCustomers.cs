using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace WPFComponents
{
  public class MyCustomers : List<MyCustomer>
  {
    public IEnumerable<MyCustomer> GetCustomerList()
    {
      AdvWorksDataContext dc = new AdvWorksDataContext();

      var items = from cust in dc.Customers
                  orderby cust.LastName
                  select new MyCustomer
                  {
                    LastName = cust.LastName,
                    FirstName = cust.FirstName
                  };

      return items;
    }
  }
}
