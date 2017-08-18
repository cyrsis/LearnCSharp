namespace Demos.DemoSupportCode.Generics
{
    internal class A {}

    internal class B : A {}

    internal class C : B {}

    internal class ConstrainedByBase<T> where T : B
    {
    }
}
