namespace TestUtils.Equality
{
    public class GetHashCodeTest<T>: TestCase
    {
        private T obj1;
        private T obj2;

        public GetHashCodeTest(T obj1, T obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }

        public override string Execute()
        {
            
            int hash1 = this.obj1.GetHashCode();
            int hash2 = this.obj2.GetHashCode();

            if (hash1 != hash2)
                return string.Format("GetHashCode({0} = {1} and GetHashCode({2}) = {3} when expecting equal values",
                                     base.ArgumentToString(this.obj1), hash1,
                                     base.ArgumentToString(this.obj2), hash2);

            return string.Empty;

        }

        public override string TestName
        {
            get { return string.Format("{0}.GetHashCode test", typeof(T).Name); }
        }
    }
}