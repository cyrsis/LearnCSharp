using Xunit;

namespace Demo.Tests
{
    public class JanitorDemo
    {
        [Fact]
        public void AccessingDisposedObject()
        {
            var o = new Location();
            
            o.Altitude = 1;
            
            o.Dispose();

            // Janitor automatically adds code to check for access to disposed objects
            o.Altitude = 2;
        }


        [Fact]
        public void ManuallyImplementingIDisposable()
        {
            var o = new ManuallyImplemented();

            o.Dispose();

            o.SomeProperty = "xyz";
        }


        [Fact]
        public void DisposingInstanceFields()
        {
            var o = new Location();

            // Janitor will find IDisposable instance fields and dispose them for us
            o.Dispose(); 
        }


        [Fact]
        public void CustomDisposeCode()
        {
            var o = new Location();

            o.Dispose();
        }
    }
}
