using Xunit;

namespace DemoUniversalApp.Shared.Tests
{
    public class CustomerAgeValidatorTests
    {
        [Fact]
        public void ShouldValidateAdult()
        {
            var sut = new CustomerAgeValidator();

            var isAdult = sut.IsAdult(18);

            Assert.True(isAdult);
        }
    }
}
