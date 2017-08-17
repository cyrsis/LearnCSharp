using System.Linq;
using System.Reflection;
using Xunit;

namespace Demo.Tests
{
    public class FielderDemo
    {
        [Fact]
        public void Example()
        {
            var p = new Person
                    {
                        Name = "Sarah"
                    };

            var props = p.GetType().GetProperties();            
        }    
    }
}
