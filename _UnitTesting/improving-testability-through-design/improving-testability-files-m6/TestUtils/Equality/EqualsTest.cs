namespace TestUtils.Equality
{
    public class EqualsTest: TestCase
    {
        private readonly object obj1;
        private readonly object obj2;
        private readonly bool expectedResult;

        public EqualsTest(object obj1, object obj2, bool expectedResult)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
            this.expectedResult = expectedResult;
        }

        public override string Execute()
        {
            
            bool actualResult = obj1.Equals(obj2);
            
            if (actualResult != expectedResult)
                return string.Format("Object.Equals({0}, {1}) returned {2} when expecting {3}",
                                     base.ArgumentToString(this.obj1),
                                     base.ArgumentToString(this.obj2),
                                     actualResult, expectedResult);
            
            return string.Empty;

        }

        public override string TestName
        {
            get { return "Object.Equals test"; }
        }
    }
}