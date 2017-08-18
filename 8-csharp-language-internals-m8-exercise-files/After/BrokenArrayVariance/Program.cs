namespace BrokenArrayVariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple[] apples = new[] { new Apple() };
            Fruit[] fruits = apples;
            fruits[0] = new Coconut(); // This line will throw at runtime
            apples[0].Peel();
        }
    }

    class Fruit
    {
    }

    class Apple : Fruit
    {
        public void Peel() { }
    }

    class Coconut : Fruit
    {
        public void Break() { }
    }
}
