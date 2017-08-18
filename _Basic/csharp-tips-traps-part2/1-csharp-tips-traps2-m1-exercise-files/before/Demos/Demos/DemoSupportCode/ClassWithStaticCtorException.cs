using System;

namespace Demos.DemoSupportCode
{
    internal class ClassWithStaticCtorException
    {
        public static readonly string Greeting = "Hello world";

        static ClassWithStaticCtorException()
        {
            throw new ApplicationException("Demo exception");
        }
    }
}