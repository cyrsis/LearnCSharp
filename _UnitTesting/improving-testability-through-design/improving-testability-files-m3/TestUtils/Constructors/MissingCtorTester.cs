using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestUtils.Constructors
{
    public class MissingCtorTester<T>: Tester<T>
    {
        public override Tester<T> Fail(object[] args, Type exceptionType, string failMessage)
        {
            return this;
        }

        public override Tester<T> Succeed(object[] args, Func<T, bool> validator, string failMessage)
        {
            return this;
        }

        public override void Assert()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Missing constructor.");
        }
    }
}
