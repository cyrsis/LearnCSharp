using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestUtils.Constructors
{
    public abstract class Tester<T>
    {
        public abstract Tester<T> Fail(object[] args, Type exceptionType, string failMessage);
        public abstract Tester<T> Succeed(object[] args, Func<T, bool> validator, string failMessage);
        public abstract void Assert();
    }
}
