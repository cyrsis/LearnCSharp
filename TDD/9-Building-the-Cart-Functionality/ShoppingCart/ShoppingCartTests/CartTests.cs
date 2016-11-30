using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShoppingCart;

namespace ShoppingCartTests
{
    [TestFixture]
    class CartTests
    {
        private Cart _cart;
        private CartItem _cartItem;
        private CartItem _cartItem2;

        [SetUp]
        public void SetUp()
        {
            _cart = new Cart();
            _cartItem = new CartItem(2, "Test", 1.00m); // 2.00m
            _cartItem2 = new CartItem(3, "Test2", 2.00m); //6.00m
        }

        [Test]
        public void CartCanContainZeroItem()
        {
            Assert.That(_cart.Items.Count, Is.EqualTo(0));
        }

        [Test]
        public void CartCanAddItem()
        {
            _cart.AddItem(_cartItem);

            Assert.That(_cart.Items, Has.Member(_cartItem));
        }

        [Test]
        public void CartContainsNoDuplicateItems()
        {
            _cart.AddItem(_cartItem);
            _cart.AddItem(_cartItem);

            Assert.That(_cart.Items.Count, Is.EqualTo(1));
        }

        [Test]
        public void CartCanRemoveItem()
        {
            _cart.AddItem(_cartItem);
            _cart.RemoveItem(_cartItem);

            Assert.That(_cart.Items.Count, Is.EqualTo(0));
        }

        [Test]
        public void TotalEqualsSumOfItemPrices()
        {
            _cart.AddItem(_cartItem);
            _cart.AddItem(_cartItem2);

            var actual = _cart.GetCartTotal();

            Assert.That(actual, Is.EqualTo(8.00m));
        }
    }

    
}
