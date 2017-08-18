using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpEquality.RefTypes.RefTypeEquality
{
	class Program
	{
		static void Main(string[] args)
		{
			Food apple = new Food("apple", FoodGroup.Fruit);
			CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
			CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
			CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
			Food apple2 = new Food("apple", FoodGroup.Fruit);

			DisplayWhetherEqual(apple, stewedApple);
			DisplayWhetherEqual(stewedApple, bakedApple);
			DisplayWhetherEqual(stewedApple, stewedApple2);
			DisplayWhetherEqual(apple, apple2);
			DisplayWhetherEqual(apple, apple);

		}

		static void DisplayWhetherEqual(Food food1, Food food2)
		{
			if (food1 == food2)
				Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
			else
				Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
		}
	}
}
