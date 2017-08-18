using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpEquality.RefTypes.RefTypeEquality
{
	public enum FoodGroup { Meat, Fruit, Vegetables, Sweets }

	public class Food
	{
		public static bool operator ==(Food x, Food y)
		{
			return object.Equals(x, y);
		}

		public static bool operator !=(Food x, Food y)
		{
			return !object.Equals(x, y);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			if (ReferenceEquals(obj, this))
				return true;
			if (obj.GetType() != this.GetType())
				return false;
			Food rhs = obj as Food;
			return this._name == rhs._name && this._group == rhs._group;
		}

		public override int GetHashCode()
		{
			return this._name.GetHashCode() ^ this._group.GetHashCode();
		}

		string _name;
		FoodGroup _group;

		public string Name { get { return _name; } }

		public Food(string name, FoodGroup group)
		{
			this._name = name;
			this._group = group;
		}

		public override string ToString()
		{
			return _name;
		}



	}
}
