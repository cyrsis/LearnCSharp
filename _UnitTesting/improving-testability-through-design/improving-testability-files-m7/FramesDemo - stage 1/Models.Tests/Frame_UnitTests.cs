using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using Moq;
using System;
using TestUtils.Constructors;
using TestUtils.PropertyTests;

namespace Models.Tests
{
    [TestClass]
    public class Frame_UnitTests
    {

        private class IsInsideOfSpy : ICircle
        {

            private readonly bool isInsideOfResult;
            public Rectangle IsInsideOfArgument { get; private set; }

            public IsInsideOfSpy(bool isInsideOfResult)
            {
                this.isInsideOfResult = isInsideOfResult;
            }

            public bool IsInsideOf(Rectangle rect)
            {
                IsInsideOfArgument = rect;
                return this.isInsideOfResult;
            }

            public ICircle Move(Location center) { return this; }
            public ICircle Resize(decimal radius) { return this; }
            public void Accept(IShapeVisitor visitor) { }
            public bool Equals(ICircle other) { return false; }

        }

        private class ShapeVisitorSpy : IShapeVisitor
        {

            private int circlesCount;
            private int matchingCirclesCount;
            private Location centerToCount;
            private decimal radiusToCount;

            public void VisitCircle(Location center, decimal radius)
            {
                this.circlesCount++;
                if (center.Equals(this.centerToCount) && radius == this.radiusToCount)
                    this.matchingCirclesCount++;
            }

            public void VisitRectangle(Rectangle rect) { }

            public int CountCircles(IShape shape)
            {
                shape.Accept(this);
                return this.circlesCount;
            }

            public int CountCircles(IShape shape, Location center, decimal radius)
            {
                this.centerToCount = center;
                this.radiusToCount = radius;
                shape.Accept(this);
                return matchingCirclesCount;
            }

        }

        [TestMethod]
        public void Constructor_FullTest()
        {

            decimal zeroPlus = DecimalPropertyTests.SmallestPositiveDecimal;

            ConstructorTests<Frame>
                .For(typeof(Size))
                .Fail(new object[] { new Size(-1.2M, 3.4M) }, typeof(ArgumentException), "Negative length")
                .Fail(new object[] { new Size(0, 3.4M) }, typeof(ArgumentException), "Zero length")
                .Fail(new object[] { new Size(1.2M, -3.4M) }, typeof(ArgumentException), "Negative width")
                .Fail(new object[] { new Size(1.2M, 0) }, typeof(ArgumentException), "Zero width")
                .Succeed(new object[] { new Size(zeroPlus, 3.4M) }, frame => true, "Small positive length")
                .Succeed(new object[] { new Size(1.2M, zeroPlus) }, frame => true, "Small positive width")
                .Succeed(new object[] { new Size(1.2M, 3.4M) }, frame => true, "Positive length and width")
                .Assert();

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_ReceivesNull_Throws()
        {
            Size size = new Size(1.2M, 3.4M);
            Frame frame = new Frame(size);
            frame.Add((ICircle)null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_ReceivesCircleOutsideTheFrame_Throws()
        {

            Location center = new Location(1.2M, 3.4M);
            decimal radius = 5.6M;
            Size size = new Size(1.0M, 1.0M);

            ICircle circle = new Circle(center, radius);
            Frame frame = new Frame(size);

            frame.Add(circle);

        }

        [TestMethod]
        public void Add_ReceivesCircle_InvokesIsInsideOfWithCorrectArgument()
        {

            Size size = new Size(1.2M, 3.4M);
            Rectangle rect = new Rectangle(new Location(0, 0), size);

            IsInsideOfSpy circle = new IsInsideOfSpy(true);
            Frame frame = new Frame(size);
            frame.Add(circle);

            Assert.AreEqual(rect, circle.IsInsideOfArgument);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_ReceivesDuplicatedCircle_Throws()
        {

            Location center = new Location(1.2M, 3.4M);
            decimal radius = 0.6M;
            Size size = new Size(5.6M, 7.8M);

            Frame frame = new Frame(size);
            ICircle circle1 = new Circle(center, radius);
            ICircle circle2 = new Circle(center, radius);
            frame = frame.Add(circle1);

            frame.Add(circle2);

        }

        [TestMethod]
        public void Add_ReceivesValidCircle_ReturnsFrameWithOneCircle()
        {

            Location center = new Location(1.2M, 3.4M);
            decimal radius = 0.6M;
            Size size = new Size(5.6M, 7.8M);

            Frame frame = new Frame(size);
            ICircle circle = new Circle(center, radius);
            frame = frame.Add(circle);

            ShapeVisitorSpy counter = new ShapeVisitorSpy();

            Assert.AreEqual(1, counter.CountCircles(frame),
                            "Incorrect number of circles in the frame.");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Replace_FirstCircleIsNull_Throws()
        {
            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Replace((ICircle)null, new Circle(new Location(1.2M, 3.4M), 0.6M));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Replace_SecondCircleIsNull_Throws()
        {
            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M), (ICircle)null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Replace_FirstCircleDoesntExist_Throws()
        {
            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new Circle(new Location(1.2M, 3.4M), 0.7M));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Replace_SecondCircleOutsideTheFrame_Throws()
        {
            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new IsInsideOfSpy(false));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Replace_SecondCircleExists_Throws()
        {
            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.7M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new Circle(new Location(1.2M, 3.4M), 0.7M));
        }

        [TestMethod]
        public void Replace_ReceivesEqualCircles_ReturnsUnchangedFrame()
        {

            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new Circle(new Location(1.2M, 3.4M), 0.6M));

            ShapeVisitorSpy counter = new ShapeVisitorSpy();

            Assert.AreEqual(1, counter.CountCircles(frame), "Incorrect number of circles after replace.");

        }

        [TestMethod]
        public void Replace_ReceivesModifiedCircle_OriginalCircleDoesntExistInFrame()
        {

            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new Circle(new Location(1.2M, 3.4M), 0.7M));

            ShapeVisitorSpy counter = new ShapeVisitorSpy();

            Assert.AreEqual(0, counter.CountCircles(frame, new Location(1.2M, 3.4M), 0.6M), "Existing circle was not removed.");

        }

        [TestMethod]
        public void Replace_ReceivesModifiedCircle_NewCircleExistsInFrame()
        {

            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Replace(new Circle(new Location(1.2M, 3.4M), 0.6M),
                         new Circle(new Location(1.2M, 3.4M), 0.7M));

            ShapeVisitorSpy counter = new ShapeVisitorSpy();

            Assert.AreEqual(1, counter.CountCircles(frame, new Location(1.2M, 3.4M), 0.7M), "New circle was not added.");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Accept_ReceivesNull_Throws()
        {
            new Frame(new Size(1.2M, 3.4M))
            .Accept((IShapeVisitor)null);
        }

        [TestMethod]
        public void Accept_ReceivesVisitor_InvokesVisitRectangleWithCorrectArgument()
        {

            Size size = new Size(1.2M, 3.4M);
            Rectangle rect = new Rectangle(new Location(), size);

            Mock<IShapeVisitor> visitorMock = new Mock<IShapeVisitor>();
            visitorMock.Setup(v => v.VisitRectangle(rect)).Verifiable();
            IShapeVisitor visitor = visitorMock.Object;

            Frame frame = new Frame(size);

            frame.Accept(visitor);

            visitorMock.Verify(v => v.VisitRectangle(rect));

        }

        [TestMethod]
        public void Accept_FrameWithOneCircle_InvokesVisitCircleWithCorrectArgument()
        {

            Location center = new Location(1.2M, 3.4M);
            decimal radius = 0.6M;
            ICircle circle = new Circle(center, radius);

            Mock<IShapeVisitor> visitorMock = new Mock<IShapeVisitor>();
            visitorMock.Setup(v => v.VisitCircle(center, radius)).Verifiable();
            IShapeVisitor visitor = visitorMock.Object;

            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(center, radius));

            frame.Accept(visitor);

            visitorMock.Verify(v => v.VisitCircle(center, radius));

        }

        [TestMethod]
        public void Accept_FrameWithThreeCircles_InvokesVisitCircleThreeTimes()
        {

            Frame frame =
                new Frame(new Size(5.6M, 7.8M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.6M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.7M))
                .Add(new Circle(new Location(1.2M, 3.4M), 0.8M));

            ShapeVisitorSpy counter = new ShapeVisitorSpy();

            Assert.AreEqual(3, counter.CountCircles(frame), "Incorrect number of calls to VisitCircle");

        }

    }
}
