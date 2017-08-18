using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpEquality.EqualityOp.EqualValueTypes
{
	public struct Food
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
