using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using TestUtils.PropertyTests;
using System.Linq;
using System;
using TestUtils.Constructors;
using TestUtils.Equality;

namespace Models.Tests
{
    [TestClass]
    public class Circle_UnitTests
    {

        [TestMethod]
        public void Constructor_FullTest()
        {
            
            Location center = new Location(1.2M, 3.4M);
            decimal zeroPlus = DecimalPropertyTests.SmallestPositiveDecimal;

            ConstructorTests<Circle>
                .For(new Type[] { typeof(Location), typeof(decimal) })
                .Succeed(new object[] { center, 5.6M }, c => true, "positive radius")
                .Succeed(new object[] { center, zeroPlus }, c => true, "small positive radius")
                .Fail(new object[] { center, 0 }, typeof(ArgumentException), "zero radius")
                .Fail(new object[] { center, -2.1M }, typeof(ArgumentException), "negative radius")
                .Assert();

        }

        [TestMethod]
        public void IsInsideOf_FullTest()
        {
            string errors = TestAllCasesIsInsideOf();
            Assert.IsTrue(string.IsNullOrEmpty(errors), "There were errors:\n" + errors);
        }

        [TestMethod]
        public void Move_ReturnsNonNull()
        {
            Circle circle = new Circle(new Location(1.2M, 3.4M), 5.6M);
            ICircle result = circle.Move(new Location(3.4M, 5.6M));
            Assert.IsNotNull(result, "Method returned null.");
        }

        [TestMethod]
        public void Move_ReceivesModifiedLocation_ReturnsMovedCircle()
        {
            Circle circle = new Circle(new Location(1.2M, 3.4M), 5.6M);
            ICircle actualResult = circle.Move(new Location(1.7M, 2.5M));
            ICircle expectedResult = new Circle(new Location(1.7M, 2.5M), 5.6M);
            Assert.AreEqual(expectedResult, actualResult, "Move returned incorrect circle.");
        }

        [TestMethod]
        public void Resize_ReturnsNonNull()
        {
            Circle circle = new Circle(new Location(1.2M, 3.4M), 5.6M);
            ICircle result = circle.Resize(7.8M);
            Assert.IsNotNull(result, "Method returned null.");
        }

        [TestMethod]
        public void Resize_RecievesModifiedRadius_ReturnsCircleWithNewRadius()
        {
            Location center = new Location(1.2M, 3.4M);
            Circle circle = new Circle(center, 5.6M);
            ICircle actualResult = circle.Resize(7.8M);
            ICircle expectedResult = new Circle(center, 7.8M);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Equality_FullTest()
        {
            EqualityTests
                .For(new Circle(new Location(1.2M, 3.4M), 5.6M))
                .EqualTo(new Circle(new Location(1.2M, 3.4M), 5.6M))
                .UnequalTo(new Circle(new Location(1.3M, 3.4M), 5.6M))
                .UnequalTo(new Circle(new Location(1.2M, 3.5M), 5.6M))
                .UnequalTo(new Circle(new Location(1.2M, 3.4M), 5.7M))
                .Assert();
        }

        private string TestAllCasesIsInsideOf()
        {

            Rectangle rect = new Rectangle(new Location(.2M, .3M), new Size(.4M, .5M));
            decimal pointOnePlus = .1M + DecimalPropertyTests.SmallestPositiveDecimal;

            string[] errors = new string[]
            {
                TestIsInsideOf(.3M, .5M, .1M, rect, true, "Touches left edge"),
                TestIsInsideOf(.4M, .4M, .1M, rect, true, "Touches upper edge"),
                TestIsInsideOf(.5M, .5M, .1M, rect, true, "Touches right edge"),
                TestIsInsideOf(.4M, .7M, .1M, rect, true, "Touches bottom edge"),
                TestIsInsideOf(.3M, .5M, pointOnePlus, rect, false, "Crosses left edge"),
                TestIsInsideOf(.4M, .4M, pointOnePlus, rect, false, "Crosses upper edge"),
                TestIsInsideOf(.5M, .5M, pointOnePlus, rect, false, "Crosses right edge"),
                TestIsInsideOf(.4M, .7M, pointOnePlus, rect, false, "Crosses bottom edge"),
                TestIsInsideOf(.4M, .5M, .1M, rect, true, "Completely inside"),
                TestIsInsideOf(.8M, 1.0M, .1M, rect, false, "Completely outside")
            };

            string error = string.Empty;

            errors = errors.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            if (errors.Length > 0)
                error = string.Join(Environment.NewLine, errors);

            return error;

        }

        private string TestIsInsideOf(decimal x, decimal y, decimal r, Rectangle rect,
                                      bool expectedResult, string testCase)
        {

            Circle circle = new Circle(new Location(x, y), r);
            bool actualResult = circle.IsInsideOf(rect);

            if (actualResult != expectedResult)
            {
                return string.Format("{0} - returned {1} instead of {2}.",
                                     testCase, actualResult, expectedResult);
            }

            return string.Empty;

        }
    }
}
