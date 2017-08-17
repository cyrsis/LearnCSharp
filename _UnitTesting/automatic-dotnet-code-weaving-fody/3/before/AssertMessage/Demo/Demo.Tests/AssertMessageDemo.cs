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



    }
}
