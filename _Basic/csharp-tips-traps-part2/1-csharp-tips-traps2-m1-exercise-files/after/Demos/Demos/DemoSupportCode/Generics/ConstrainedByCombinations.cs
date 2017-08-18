namespace Demos.DemoSupportCode.Generics
{
    internal interface ICookable {}

    internal abstract class Fruit {}

    internal class Orange : Fruit { }

    internal class Pear : Fruit, ICookable
    {
        private Pear() { }
    }

    internal class Apple : Fruit, ICookable {}



    internal class ConstrainedByCombinations<T> where T : Fruit, ICookable, new()
    {
    }
}
