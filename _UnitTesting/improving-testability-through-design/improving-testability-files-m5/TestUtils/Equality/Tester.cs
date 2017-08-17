using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TestUtils.Equality
{
    public class Tester<T>
    {

        private readonly T objectToCompare;
        private readonly TestCase[] testCases;

        public Tester(T obj)
        {

            this.objectToCompare = obj;

            List<TestCase> tests = new List<TestCase>()
            {
                new EqualityOperatorSignatureTest<T>(),
                new InequalityOperatorSignatureTest<T>()
            };

            if (!typeof(T).IsValueType)
            {
                tests.Add(new EqualsTest(obj, null, false));
                tests.Add(new TypedEqualsTest<T>(obj, default(T), false));
                tests.Add(new EqualityOperatorTest<T>(obj, default(T), false));
                tests.Add(new InequalityOperatorTest<T>(obj, default(T), true));
                tests.AddRange(FindInterfaceEqualsTests(default(T), false));
            };

            this.testCases = tests.ToArray();

        }

        private Tester(Tester<T> tester, TestCase testCase)
        {

            TestCase[] testCases = new TestCase[tester.testCases.Length + 1];
            Array.Copy(tester.testCases, testCases, tester.testCases.Length);
            testCases[tester.testCases.Length] = testCase;

            this.objectToCompare = tester.objectToCompare;
            this.testCases = testCases;

        }

        public Tester<T> EqualTo(T obj)
        {
            return this
                .Add(new EqualsTest(this.objectToCompare, obj, true))
                .Add(new TypedEqualsTest<T>(this.objectToCompare, obj, true))
                .Add(new EqualityOperatorTest<T>(this.objectToCompare, obj, true))
                .Add(new InequalityOperatorTest<T>(this.objectToCompare, obj, false))
                .Add(new GetHashCodeTest<T>(this.objectToCompare, obj))
                .AddInterfacesEqualsTests(obj, true);
        }

        public Tester<T> UnequalTo(T obj)
        {
            return this
                .Add(new EqualsTest(this.objectToCompare, obj, false))
                .Add(new TypedEqualsTest<T>(this.objectToCompare, obj, false))
                .Add(new EqualityOperatorTest<T>(this.objectToCompare, obj, false))
                .Add(new InequalityOperatorTest<T>(this.objectToCompare, obj, true))
                .AddInterfacesEqualsTests(obj, false);
        }

        private Tester<T> Add(TestCase testCase)
        {
            return new Tester<T>(this, testCase);
        }

        private Tester<T> AddInterfacesEqualsTests(T obj, bool expectedResult)
        {

            Tester<T> tester = this;
            foreach (TestCase tc in FindInterfaceEqualsTests(obj, expectedResult))
                tester = tester.Add(tc);

            return tester;

        }

        private IEnumerable<TestCase> FindInterfaceEqualsTests(T obj, bool expectedResult)
        {

            List<TestCase> tests = new List<TestCase>();

            foreach (Type baseInterface in typeof(T).GetInterfaces())
            {

                Type iequatableType = typeof(IEquatable<>).MakeGenericType(baseInterface);

                if (typeof(T).GetInterfaces().Any(x => x == iequatableType))
                {

                    Type testerType = typeof(TypedEqualsTest<>).MakeGenericType(baseInterface);

                    ConstructorInfo ctor = testerType.GetConstructor(new Type[] { baseInterface, baseInterface, typeof(bool) });
                    object[] arguments = new object[] { this.objectToCompare, obj, expectedResult };

                    TestCase testCase = (TestCase)ctor.Invoke(arguments);

                    tests.Add(testCase);

                }
            }

            return tests;

        }

        public void Assert()
        {
            string errors = CollectErrors();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert
                .IsTrue(string.IsNullOrEmpty(errors), errors);
        }

        private string CollectErrors()
        {

            string[] errors = ExecuteTestCases();

            if (errors.Length > 0)
                return string.Format("Some test cases failed:\n{0}",
                                     string.Join(Environment.NewLine, errors));

            return string.Empty;

        }

        private string[] ExecuteTestCases()
        {
            return this.testCases.Select(tc => ExecuteTestCase(tc))
                                 .Where(s => !string.IsNullOrEmpty(s)).ToArray();
        }

        private string ExecuteTestCase(TestCase testCase)
        {
            try
            {
                return testCase.Execute();
            }
            catch (System.Exception ex)
            {
                return string.Format("{0} threw {1}: {2}", 
                                     testCase.TestName, ex.GetType().Name, ex.Message);
            }
        }
    }
}