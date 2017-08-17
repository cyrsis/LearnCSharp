using System;

namespace TestUtils.Equality
{
    public static class EqualityTests
    {
        public static Tester<T> For<T>(T obj)
        {
            return new Tester<T>(obj);
        }
    }
}