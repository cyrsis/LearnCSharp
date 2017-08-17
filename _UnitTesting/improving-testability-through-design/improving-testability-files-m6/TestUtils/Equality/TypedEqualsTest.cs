using System;
using System.Linq;

namespace TestUtils.Equality
{
    public class TypedEqualsTest<T>: TestCase
    {
        private IEquatable<T> obj1;
        private T obj2;
        private bool expectedResult;

        public TypedEqualsTest(T obj1, T obj2, bool expectedResult)
        {
            this.obj1 = obj1 as IEquatable<T>;
            this.obj2 = obj2;
            this.expectedResult = expectedResult;
        }

        public override string Execute()
        {
            
            if (typeof(T).GetInterfaces().All(x => x != typeof(IEquatable<T>)))
                return string.Empty;

            bool actualResult = ((IEquatable<T>)obj1).Equals(obj2);
            if (actualResult != this.expectedResult)
                return string.Format("IEquatable<{0}>.Equals({1}, {2}) returned {3} when expecting {4}",
                                     typeof(T).Name, base.ArgumentToString(this.obj1),
                                     base.ArgumentToString(this.obj2), actualResult, expectedResult);

            return string.Empty;

        }

        public override string TestName
        {
            get { return string.Format("IEquatable<{0}>.Equals test", typeof(T).Name); }
        }
    }
}