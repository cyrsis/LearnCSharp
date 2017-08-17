using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.Common;
using TestUtils.ImmutableStructures;

namespace Models.Tests
{
    [TestClass]
    public class Size_UnitTests
    {
        [TestMethod]
        public void FullTest()
        {
            ImmutableStructureTests<Size>
                .ConstructorParameter(1.2M, "Length")
                .ConstructorParameter(3.4M, "Width")
                .Assert();
        }
    }
}
