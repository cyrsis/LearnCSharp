using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class RuntimeConversionsExample
    {
        [TestMethod]
        public void Example()
        {
            Type targetType;
            Type convertedType;
            object convertedValue;
            object initialValue;


            initialValue = "99";            
            targetType = typeof (int);

            convertedValue = Convert.ChangeType(initialValue, targetType);            
            convertedType = convertedValue.GetType();


            targetType = typeof (double);

            convertedValue = Convert.ChangeType(initialValue, targetType);
            convertedType = convertedValue.GetType();
        }
    }
}