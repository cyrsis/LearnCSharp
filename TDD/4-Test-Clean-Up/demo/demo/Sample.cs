using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace demo
{
    class Sample
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsTestingFun()
        {
            return true;
        }
    }

    [TestFixture]
    public class SampleTests
    {
        private Sample s;

        [SetUp]
        public void SetUp()
        {
            s = new Sample();
        }

        [Test]
        public void AddReturnsSumOfBothParams()
        {
            int result = s.Add(1, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void IsTestingFunReturnsTrue()
        {
            bool result = s.IsTestingFun();

            Assert.AreEqual(true, result);
        }
    }
}
