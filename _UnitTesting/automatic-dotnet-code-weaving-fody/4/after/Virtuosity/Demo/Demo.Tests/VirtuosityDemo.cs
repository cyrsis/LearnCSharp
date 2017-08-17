using Demo.People;
using Rhino.Mocks;
using Xunit;

namespace Demo.Tests
{
    public class VirtuosityDemo
    {
        [Fact]
        public void RhinoExample()
        {
            var mockPerson = MockRepository.GenerateStub<Person>();

            mockPerson.Stub(x => x.CalculateFullName()).Return("mock name");

            var name = mockPerson.CalculateFullName();

            Assert.Equal("mock name", name);
        }
    }
}
