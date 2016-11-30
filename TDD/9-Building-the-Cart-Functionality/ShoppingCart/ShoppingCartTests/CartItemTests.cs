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
    class CartItemTests
    {
        private int _quantity;
        private string _description;
        private CartItem _item;
        private decimal _unitPrice;
        private decimal _itemPrice;
        private int _newQuantity;
        private decimal _discountAmount;
        private decimal _largeDiscount;
        private decimal _zero;

        [SetUp]
        public void SetUp()
        {
            _quantity = 2;
            _description = "Test Description";
            _unitPrice = 1.00m;
            _itemPrice = 2.00m;
            _newQuantity = 3;
            _discountAmount = 1.00m;
            _largeDiscount = 3.00m;
            _zero = 0m;
            _item = new CartItem(_quantity, _description, _unitPrice);
        }

        [Test]
        public void ItemHasQuantity()
        {
            Assert.That(_item.Quantity, Is.EqualTo(_quantity));
        }

        [Test]
        public void ItemHasDescription()
        {
            Assert.That(_item.Description, Is.EqualTo(_description));
        }

        [Test]
        public void ItemHasUnitPrice()
        {
            Assert.That(_item.UnitPrice, Is.EqualTo(_unitPrice));
        }

        [Test]
        public void ItemPriceIsQuantityTimesUnitPrice()
        {
            var actual = _item.GetItemPrice();

            Assert.That(actual, Is.EqualTo(_itemPrice));
        }

        [Test]
        public void QuanityIsModifiable()
        {
            _item.Quantity = _newQuantity;

            Assert.That(_item.Quantity, Is.EqualTo(_newQuantity));
        }

        [Test]
        public void DiscountCanBeAppliedToItem()
        {
            _item.ApplyDiscount(_discountAmount);

            Assert.That(_item.Discount, Is.EqualTo(_discountAmount));
        }

        [Test]
        public void ItemPriceWithDiscountCannotBeLessThanZero()
        {
            _item.ApplyDiscount(_largeDiscount);

            Assert.That(_item.GetItemPrice(), Is.EqualTo(_zero));
        }
    }

    
}
