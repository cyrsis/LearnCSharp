using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using Moq;

namespace Models.Tests
{
    [TestClass]
    public class Frame_UnitTests
    {

        private readonly decimal SmallestPositiveDecimal = 1e-28M;

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Length_ReceivesNegativeValue_Throws()
        {
            AssertLength(-3.5M);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Length_ReceivesZero_Throws()
        {
            AssertLength(0);
        }

        [TestMethod]
        public void Length_ReceivesSmallestPositiveValue_GetterReturnsSameValue()
        {
            AssertLength(SmallestPositiveDecimal);
        }

        [TestMethod]
        public void Length_ReceivesPositiveValue_GetterReturnsSameValue()
        {
            AssertLength(3.7M);
        }

        private void AssertLength(decimal value)
        {
            Frame frame = new Frame();
            frame.Length = value;
            Assert.AreEqual(value, frame.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Width_ReceivesNegativeValue_Throws()
        {
            AssertWidth(-3.3M);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Width_ReceivesZero_Throws()
        {
            AssertWidth(0);
        }

        [TestMethod]
        public void Width_ReceivesSmallestPositiveValue_GetterReturnsSameValue()
        {
            AssertWidth(SmallestPositiveDecimal);
        }

        [TestMethod]
        public void Width_ReceivesPositiveValue_GetterReturnsSameValue()
        {
            AssertWidth(3.1M);
        }

        private static void AssertWidth(decimal value)
        {
            Frame frame = new Frame();
            frame.Width = value;
            Assert.AreEqual(value, frame.Width);
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
            Frame frame = new Frame() { Length = 3.0M, Width = 3.0M };

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
            Frame frame = new Frame();
            frame.Length = 3.0M;
            frame.Width = 3.0M;
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
