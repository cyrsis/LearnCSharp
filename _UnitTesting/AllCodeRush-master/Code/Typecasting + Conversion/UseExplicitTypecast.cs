using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Data;
namespace AllCodeRush.Code.TypecastingConversion
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Use Explicit Typecast
	         
			Use Case: Converts an implicit typecast expression into 
	    an explicit Typecast.
		 
			Available: When the caret is on an implicit typecast 
	    expression. 
		•—————————————————————————————————————————————————————————• */

	public class UseExplicitTypecast
	{
		public void ProcessCustomers()
		{
			ArrayList Customers = GetCustomerList();

			// Iterate Potential Customers
			foreach (Object customer in Customers)
			{
				Customer Cust = customer as Customer;
				// Double check that only Real customers exist in the Customer list.
				if (Cust == null)
					continue;
				// Normal customer processing here
			}
		}

		#region Support
		private static ArrayList GetCustomerList()
		{
			ArrayList MyList = new ArrayList();
			MyList.Add(new Customer("Bob", "Kensington"));
			MyList.Add(new Customer("Alice", "Kinson"));
			MyList.Add(new Customer("Carter", "Manning"));
			MyList.Add(new Customer("John", "Fraser"));
			MyList.Add("John");
			return MyList;
		}
		#endregion
	}
}
