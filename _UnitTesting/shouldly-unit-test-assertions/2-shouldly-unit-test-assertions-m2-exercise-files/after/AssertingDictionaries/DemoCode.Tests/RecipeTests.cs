using System.Runtime.InteropServices.ComTypes;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class RecipeTests
    {
        [Fact]
        public void ShouldAddIngredients()
        {
            var applePie = new Recipe("Apple Pie");

            applePie.AddIngredient("Apples", 200);
            applePie.AddIngredient("Sugar", 50);
            applePie.AddIngredient("Pastry", 300);

            applePie.Ingredients.ShouldContainKey("Apples");
            applePie.Ingredients.ShouldNotContainKey("Cherries");
            applePie.Ingredients.ShouldContainKeyAndValue("Sugar", 50);
            applePie.Ingredients.ShouldNotContainValueForKey("Sugar", 50);

        }

    }
}
