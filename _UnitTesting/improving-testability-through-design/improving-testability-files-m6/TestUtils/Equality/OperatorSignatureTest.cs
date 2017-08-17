using System.Reflection;

namespace TestUtils.Equality
{
    public class OperatorSignatureTest<T>: TestCase
    {

        private readonly string signature;
        private readonly string methodName;

        protected OperatorSignatureTest(string signature, string methodName)
        {
            this.signature = signature;
            this.methodName = methodName;
        }

        public override string Execute()
        {
            
            if (!OperatorExists())
                return string.Format("{0} does not implement operator {1}",
                                     typeof(T).Name, this.signature);
        
            return string.Empty;
        
        }

        private bool OperatorExists()
        {
            BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.Public;
            MethodInfo method = typeof(T).GetMethod(this.methodName, bindingFlags);
            return method != null;
        }

        public override string TestName
        {
            get { return string.Format("Operator {0} signature test", this.signature); }
        }
    }
}