using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using Moq;
using System;
using System.Reflection;
using TestUtils.Constructors;
using TestUtils.PropertyTests;

namespace Models.Tests
{
    [TestClass]
    public class Frame_UnitTests
    {

        [TestMethod]
        public void Constructor_FullTest()
        {

            decimal zeroPlus = DecimalPropertyTests.SmallestPositiveDecimal;

            ConstructorTests<Frame>
                .For(typeof(Size))
                .Fail(new object[] { new Size { Length = -1.0M, Width = 1.0M } },
                        typeof(ArgumentException), "Negative length")
                .Fail(new object[] { new Size { Length = 0, Width = 1.0M } },
                        typeof(ArgumentException), "Zero length")
                .Fail(new object[] { new Size { Length = 1.0M, Width = -1.0M } },
                        typeof(ArgumentException), "Negative width")
                .Fail(new object[] { new Size { Length = 1.0M, Width = 0 } },
                        typeof(ArgumentException), "Zero width")
                .Succeed(new object[] { new Size { Length = zeroPlus, Width = 1.0M } },
                        (f) => f.Length == zeroPlus, "Small positive length")
                .Succeed(new object[] { new Size { Length = 1.0M, Width = zeroPlus } },
                        (f) => f.Width == zeroPlus, "Small positive width")
                .Succeed(new object[] { new Size { Length = 3.4M, Width = 1.0M } },
                        (f) => f.Length == 3.4M, "Larger positive length")
                .Succeed(new object[] { new Size { Length = 1.0M, Width = 3.7M } },
                        (f) => f.Width == 3.7M, "Larger positive width")
                .Assert();
        }

        [TestMethod]
        public void Length_FullTest()
        {
            Frame frame = new Frame(new Size() { Length = 1.0M, Width = 2.0M });
            DecimalPropertyTests.TestDecimalPositiveProperty(frame, "Length");
        }

        [TestMethod]
        public void Width_FullTest()
        {
            Frame frame = new Frame(new Size() { Length = 1.0M, Width = 2.0M });
            DecimalPropertyTests.TestDecimalPositiveProperty(frame, "Width");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void TryAddCircle_ReceivesNull_Throws()
        {
            Frame frame = new Frame(new Size { Length = 3.0M, Width = 4.0M });
            frame.TryAddCircle((ICircle)null);
        }

        [TestMethod]
        public void TryAddCircle_CircleEntirelyInsideFrame_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesLeftEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.0M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesTopEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 1.0M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesRightEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(2.0M, 1.5M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleTouchesBottomEdge_ReturnsTrue()
        {
            AssertTryAddCircleResult(1.5M, 2.0M, true);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesLeftEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(0.7M, 1.5M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesTopEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(1.5M, 0.7M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesRightEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(2.3M, 1.5M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCrossesBottomEdge_ReturnsFalse()
        {
            AssertTryAddCircleResult(1.5m, 2.3M, false);
        }

        [TestMethod]
        public void TryAddCircle_CircleCompletelyOutsideTheFrame_ReturnsFalse()
        {
            AssertTryAddCircleResult(5.4M, 6.1M, false);
        }

        [TestMethod]
        public void CirclesCount_CircleInsideTheFrame_ReturnsOne()
        {
            AssertCirclesCount(1.5M, 1.5M, 1);
        }

        [TestMethod]
        public void CirclesCount_CircleOutsideTheFrame_ReturnsZero()
        {
            AssertCirclesCount(0.7M, 1.5M, 0);
        }

        [TestMethod]
        public void TryAddCircle_CircleEqualToExistingCircle_ReturnsFalse()
        {
        
            Circle circle1 = new Circle() { X = 1.5M, Y = 1.5M, Radius = 1.0M };
            Circle circle2 = new Circle() { X = 1.5M, Y = 1.5M, Radius = 1.0M };
            Frame frame = new Frame(new Size() { Length = 3.0M, Width = 3.0M });

            frame.TryAddCircle(circle1);
            bool result = frame.TryAddCircle(circle2);

            Assert.IsFalse(result);
        
        }

        [TestMethod]
        public void TryAddCircle_CircleNotEqualToExistingCircle_ReturnsTrue()
        {
            bool equalsResult = false;
            bool expectedResult = true;
            AssertTryAddCircleTwoCircles(equalsResult, expectedResult);
        }

        private void AssertTryAddCircleTwoCircles(bool equalsResult, bool expectedResult)
        {
            Frame frame = CreateTestingFrame();
            ICircle circle1 = MockCircle(1.5M, 1.5M, equalsResult);
            ICircle circle2 = MockCircle(1.5M, 1.6M, equalsResult);

            frame.TryAddCircle(circle1);
            bool result = frame.TryAddCircle(circle2);

            Assert.AreEqual(expectedResult, result);
        }

        private void AssertTryAddCircleResult(decimal x, decimal y, bool expectedResult)
        {
            bool result = InvokeTryAddCircle(x, y);
            Assert.AreEqual(expectedResult, result);
        }

        private void AssertCirclesCount(decimal x, decimal y, int expectedCount)
        {
            Frame frame;
            InvokeTryAddCircle(x, y, out frame);
            Assert.AreEqual(expectedCount, frame.CirclesCount);
        }

        private bool InvokeTryAddCircle(decimal x, decimal y)
        {
            Frame frame;
            return InvokeTryAddCircle(x, y, out frame);
        }

        private bool InvokeTryAddCircle(decimal x, decimal y, out Frame frame)
        {
            frame = CreateTestingFrame();
            ICircle circle = MockCircle(x, y);
            return frame.TryAddCircle(circle);
        }

        private Frame CreateTestingFrame()
        {
            Frame frame = new Frame(new Size { Length = 3.0M, Width = 3.0M });
            return frame;
        }

        private ICircle MockCircle(decimal x, decimal y, bool equalsResult = false)
        {
            Mock<ICircle> circleMock = new Mock<ICircle>();
            circleMock.SetupGet(c => c.X).Returns(x);
            circleMock.SetupGet(c => c.Y).Returns(y);
            circleMock.SetupGet(c => c.Radius).Returns(1.0M);
            circleMock.Setup(c => c.Equals(It.IsAny<ICircle>())).Returns(equalsResult);
            ICircle circle = circleMock.Object;
            return circle;
        }

    }
}
