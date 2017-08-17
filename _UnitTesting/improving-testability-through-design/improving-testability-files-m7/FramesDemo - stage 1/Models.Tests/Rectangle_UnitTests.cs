using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using TestUtils.ImmutableStructures;

namespace Models.Tests
{
    [TestClass]
    public class Rectangle_UnitTests
    {
        [TestMethod]
        public void FullTest()
        {
            ImmutableStructureTests<Rectangle>
                .ConstructorParameter(new Location(1.2M, 3.4M))
                .ConstructorParameter(new Size(5.4M, 7.2M))
                .Property("Left", 1.2M)
                .Property("Top", 3.4M)
                .Property("Right", 6.6M)
                .Property("Bottom", 10.6M)
                .Assert();
        }
    }
}
