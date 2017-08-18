using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpEquality.FoodEqualsButton
{
	public class Food
	{
		private string _name;
		public string Name { get { return _name; } }

		public Food(string name)
		{
			this._name = name;
		}

		public override string ToString()
		{
			return _name;
		}
	}
}
