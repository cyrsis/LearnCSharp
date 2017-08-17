using System;
using System.Reflection;

namespace TestUtils.Constructors
{
    public static class ConstructorTests<T>
    {
        public static Tester<T> For(params Type[] argTypes)
        {
            ConstructorInfo ctor = typeof(T).GetConstructor(argTypes);

            if (ctor == null)
                return new MissingCtorTester<T>();

            return new CtorTester<T>(ctor);

        }
    }
}
