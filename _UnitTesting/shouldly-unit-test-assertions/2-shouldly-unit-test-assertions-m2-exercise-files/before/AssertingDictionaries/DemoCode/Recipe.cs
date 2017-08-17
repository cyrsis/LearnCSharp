using System.Collections.Generic;

namespace DemoCode
{
    public class Recipe
    {
        public Recipe(string name)
        {
            Name = name;
            Ingredients = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> Ingredients { get; private set; }

        public void AddIngredient(string ingredientName, int weight)
        {
            Ingredients.Add(ingredientName, weight);
        }
    }
}