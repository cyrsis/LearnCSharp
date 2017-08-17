using System;
using System.Reflection;

namespace TestUtils.Equality
{
    public class OperatorTest<T>: TestCase
    {
        private T obj1;
        private T obj2;
        private readonly string signature;
        private readonly string methodName;
        private readonly bool expectedResult;

        protected OperatorTest(string signature, string methodName, T obj1, T obj2, bool expectedResult)
        {
            this.signature = signature;
            this.methodName = methodName;
            this.obj1 = obj1;
            this.obj2 = obj2;
            this.expectedResult = expectedResult;
        }

        public override string Execute()
        {
            MethodInfo method = FindOperator();
            return TestOperator(method);
        }

        private MethodInfo FindOperator()
        {
            BindingFlags bindingFlags = BindingFlags.Static | BindingFlags.Public;
            return typeof(T).GetMethod(this.methodName, bindingFlags);
        }

        private string TestOperator(MethodInfo method)
        {
            
            if (method == null)
                return string.Empty;

            return SafeTestOperator(method);
        
        }

        private string SafeTestOperator(MethodInfo method)
        {
            bool actualResult = CallOperator(method);

            if (actualResult != this.expectedResult)
                return string.Format("{0} {1} {2} returned {3} when expecting {4}",
                                     base.ArgumentToString(this.obj1), this.signature,
                                     base.ArgumentToString(this.obj2), actualResult, expectedResult);

            return string.Empty;
        }

        private bool CallOperator(MethodInfo method)
        {
            try
            {
                return (bool)method.Invoke(null, new object[] { this.obj1, this.obj2 });
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        public override string TestName
        {
            get { return string.Format("Operator {0} test", this.signature); }
        }
    }
}