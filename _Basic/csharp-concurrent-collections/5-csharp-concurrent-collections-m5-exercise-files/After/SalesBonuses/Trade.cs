using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ConcurrentCollections.SalesBonuses
{
	public class Trade
	{
		public SalesPerson Person { get; private set; }

		//  QuantitySold is negative if the trade was a purchase
		public int QuantitySold { get; private set; }

		public Trade(SalesPerson person, int quantitySold)
		{
			this.Person = person;
			this.QuantitySold = quantitySold;
		}
	}

}
