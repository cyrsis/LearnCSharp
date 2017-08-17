namespace TestUtils.Equality
{
    public abstract class TestCase
    {
        public abstract string Execute();
        public abstract string TestName { get; }

        protected string ArgumentToString(object obj)
        {
            if (obj == null)
                return "null";
            return obj.ToString();
        }
    }
}