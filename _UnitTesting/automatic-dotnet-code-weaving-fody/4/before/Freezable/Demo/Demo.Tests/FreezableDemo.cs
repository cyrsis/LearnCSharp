using System;
using Xunit;

namespace Demo.Tests
{
    public class FreezableDemo
    {
        [Fact]
        public void Freeze()
        {
            var p = new Person
                    {
                        FirstName = "Jason",
                        LastName = "Roberts"
                    };

            // Not yet frozen
            p.FirstName = "Gentry";

            p.Freeze();

            Assert.Throws<InvalidOperationException>(() => p.FirstName = "Sarah");
        
        }

    
    }
}
