using Xunit;

namespace DemoCode.Tests
{
    [CollectionDefinition("MemoryCalculator Collection")]
    public class MemoryCalculatorCollection : ICollectionFixture<MemoryCalculatorFixture>
    {
    }
}
