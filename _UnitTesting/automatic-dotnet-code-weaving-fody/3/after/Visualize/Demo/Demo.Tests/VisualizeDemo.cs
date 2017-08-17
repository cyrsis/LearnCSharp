using System.Collections.Generic;
using Xunit;

namespace Demo.Tests
{
    public class VisualizeDemo
    {
        [Fact]
        public void SimpleExample()
        {
            var p = new Person
                    {
                        Name = "Gentry",
                        Age = 42,
                        HomeTown = "Brisbane",
                        Password = "secret"
                    };            
        }


        [Fact]
        public void DataAnnotations()
        {
            var p = new AnnotatedPerson
            {
                Name = "Gentry",
                Age = 42,
                HomeTown = "Brisbane",
                Password = "secret"
            };
        }  
    }
}
