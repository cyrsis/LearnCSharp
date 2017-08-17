using System;
using NUnit.Framework;

namespace DemoCode.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldHaveALongBow()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }


        [Test]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.NickName, Is.Null);
        }


        [Test]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.That(sut.IsNoob, Is.True);
        }

        [Test]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Divide(10, 0), Throws.InstanceOf<DivideByZeroException>());
        }

        [Test]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();

            var result = sut.AddInts(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            Assert.That(sut.Health, Is.InRange(101,200));
        }


        [Test]
        public void ShouldJoinNames_SubstringContents()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.That(fullName, Contains.Substring("Sarah"));
        }


        [Test]
        [TestCase(5, 10, -15)]
        [TestCase(-5, -10, 15)]
        [TestCase(10, 0, -10)]
        [TestCase(0, 0, 0)]
        [TestCase(-99, 99, 0)]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.That(sut.CurrentValue, Is.EqualTo(expectedResult));
        }
    }
}
