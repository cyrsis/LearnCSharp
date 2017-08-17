using System.Collections.Generic;
using Xunit;

namespace Demo.Tests
{
    public class ToStringDemo
    {
        [Fact]
        public void Manual()
        {
            var o = new ManualToString
                    {
                        Age = 42,
                        HomeTown = "LA",
                        Name = "Sarah",
                        Password="secret"
                    };

            var s = o.ToString();
        }

        [Fact]
        public void Auto()
        {
            var o = new AutoToString
                    {
                        Age = 42,
                        HomeTown = "LA",
                        Name = "Sarah",
                        Password = "secret"
                    };

            var s = o.ToString();
        }
        
        
        [Fact]
        public void Collections()
        {
            var o = new CollectionExample
                    {                        
                        Name = "Sarah",
                        Places = new List<string> { "LA", "Perth", "London"}
                    };

            var s = o.ToString();
        }
    }
}
