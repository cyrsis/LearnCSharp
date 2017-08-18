namespace Demos.DemoSupportCode.Generics
{
    internal class FooWithCtor
    {
        // comes with a default parameterless ctor
    }

    internal class FooWithPrivateCtor
    {
        private FooWithPrivateCtor() {}
    }

    internal class FooWithParameterizedCtor
    {
        public FooWithParameterizedCtor(int a) { }
    }

    internal class ConstrainedByCtor<T>  where T : new()
    {
        public T CreateANewT()
        {
            return new T();
        }
    }
}