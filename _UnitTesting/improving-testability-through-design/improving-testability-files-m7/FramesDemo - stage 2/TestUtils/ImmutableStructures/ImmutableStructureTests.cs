namespace TestUtils.ImmutableStructures
{
    public static class ImmutableStructureTests<T>
    {
        public static Tester<T> ConstructorParameter<A>(A value, string propertyName)
        {
            return new Tester<T>().ConstructorParameter<A>(value, propertyName);
        }

        public static Tester<T> ConstructorParameter<A>(A value)
        {
            return new Tester<T>().ConstructorParameter<A>(value);
        }

        public static Tester<T> Property<A>(string name, A value)
        {
            return new Tester<T>().Property<A>(name, value);
        }
    }
}
