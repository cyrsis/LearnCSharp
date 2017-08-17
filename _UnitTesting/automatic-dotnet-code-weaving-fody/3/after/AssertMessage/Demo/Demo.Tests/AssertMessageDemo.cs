using NUnit.Framework;

namespace Demo.Tests
{
    public class AssertMessageDemo
    {
        [Test]
        public void SimpleExample()
        {
            var p = new Person
                    {
                        Name = "Gentry"
                    };

            Assert.AreEqual("Sarah", p.Name);
        }

 //Expected string length 5 but was 6. Strings differ at index 0.
 // Expected: "Sarah"
 // But was:  "Gentry"
 // -----------^

//Assert.AreEqual("Sarah", p.Name);
//  Expected string length 5 but was 6. Strings differ at index 0.
//  Expected: "Sarah"
//  But was:  "Gentry"
//  -----------^
    }
}
