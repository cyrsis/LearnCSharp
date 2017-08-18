using System;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class NullableValueTypes
    {
        [TestMethod]
        public void Creating()
        {
            int nonNullableInt = 22;

            // nonNullableInt = null; // value type, cannot be set to null

            Nullable<int> nullableInt = null;

            int? anotherNullableInt = null;
        }









        [TestMethod]
        public void CheckingForNull()
        {
            int? i = null;

            // Determining if null
            var isNull = ! i.HasValue;
            isNull = i == null;

            i = 42;
            isNull = ! i.HasValue;
        }








        [TestMethod]
        public void GettingUnderlyingValue()
        {
            int? i = 42;  // implicit conversion

            int value = i.Value;
            value = (int)i;  // explicit conversion


            i = null;
            value = i.Value;
            value = (int)i;
        }








        [TestMethod]
        public void EqualityAndRelationalOperators()
        {
            int? nullableA = 42; 
            int? nullableB = 42; 
            int nonNullable = 42;

            // Equality ( == != )
            var isEqual = nullableA == nonNullable; // uses operators from the underlying type

            isEqual = nullableA == null;

            nullableA = null;
            nullableB = null;
            isEqual = nullableA == nullableB;
            
            // Relational ( < <= >= > )
            nullableA = 42;
            nullableB = null;
            var isGreater = nullableA > null;
            isGreater = nullableA > nullableB;
            isGreater = 43 > nullableA;
        }









        [TestMethod]
        public void GetValueOrDefault()
        {
            int? i = 42;

            int value = (int) i;

            value = i.GetValueOrDefault();

            i = null;

            value = i.GetValueOrDefault();

            value = i.GetValueOrDefault(int.MinValue);
        }






        [TestMethod]
        public void UseInAmbientProperties()
        {
            var page = new Page
                           {
                               FontSize = 18
                           };

            var para = new Paragraph
                           {
                               Parent = page
                           };
           

            para.FontSize = 72;

            para.FontSize = 18;

            page.FontSize = 36;
        }
    }  
}