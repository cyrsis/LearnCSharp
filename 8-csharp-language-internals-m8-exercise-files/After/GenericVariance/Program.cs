namespace GenericVariance
{
    class Program
    {
        static void Main()
        {
            IReader<Apple> appleReader = null;
            IReader<Fruit> fruitReader = appleReader;

            IWriter<Fruit> fruitWriter = null;
            IWriter<Apple> appleWriter = fruitWriter;
        }
    }

    interface IReader<out T>
    {
        T Read();
    }

    interface IWriter<in T>
    {
        void Write(T value);
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
