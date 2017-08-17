using Xunit;

namespace Demo.Tests
{
    public class MethodDecoratorDemo
    {
        [Fact]
        public void EntryExitDemo()
        {
            var p = new Person
                    {
                        FirstName = "Jason",
                        LastName = "Roberts"
                    };

            var fullName = p.CalculateFullName();
        }

        [Fact]
        public void ExceptionDemo()
        {
            var p = new Person();
            // Don't set a name to create an exception

            var fullName = p.CalculateFullName();
        }    
    }
}
