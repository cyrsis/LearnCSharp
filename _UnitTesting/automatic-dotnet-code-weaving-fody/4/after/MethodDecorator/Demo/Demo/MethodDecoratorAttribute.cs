using System;
using System.Diagnostics;
using System.Reflection;

namespace Demo
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class MethodDecoratorAttribute : Attribute, IMethodDecorator
    {
        public void OnEntry(MethodBase method)
        {
            Debug.WriteLine("Entering " + method.Name);
        }        

        public void OnExit(MethodBase method)
        {
            Debug.WriteLine("Exiting " + method.Name);
        }

        public void OnException(MethodBase method, Exception exception)
        {
            Debug.WriteLine("Sorry, there was an exception in " + method.Name);
            Debug.WriteLine(exception);
        }
    }
}
