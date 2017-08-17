using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using TestUtils.ImmutableStructures;

namespace Models.Tests
{
    [TestClass]
    public class Location_UnitTests
    {
        [TestMethod]
        public void FullTest()
        {
            ImmutableStructureTests<Location>
                .ConstructorParameter(1.2M, "X")
                .ConstructorParameter(3.4M, "Y")
                .Assert();
        }
    }
}
