using System;
using Xunit;

namespace DemoCode.Tests
{   
    public class Tests
    {
        [Fact]
        public void ShouldHaveALongBow()
        {
            var sut = new PlayerCharacter();

            Assert.Contains("Long Bow", sut.Weapons);
        }


        [Fact]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            Assert.Null(sut.NickName);
        }


        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide(10, 0));
        }

        [Fact]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();

            var result = sut.AddInts(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            Assert.InRange(sut.Health, 101, 200);
        }


        [Fact]
        public void ShouldJoinNames_SubstringContents()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            Assert.Contains("Sarah", fullName);
        }


        [Theory]
        [InlineData(5, 10, -15)]
        [InlineData(-5, -10, 15)]
        [InlineData(10, 0, -10)]
        [InlineData(0, 0, 0)]
        [InlineData(-99, 99, 0)]
        public void ShouldSubtractTwoNumbers(int firstNumber, int secondNumber, int expectedResult)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNumber);
            sut.Subtract(secondNumber);

            Assert.Equal(expectedResult, sut.CurrentValue);
        }
    }
}
