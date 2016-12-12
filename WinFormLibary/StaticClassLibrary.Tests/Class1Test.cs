// <copyright file="Class1Test.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using StaticClassLibrary;

namespace StaticClassLibrary.Tests
{
    /// <summary>This class contains parameterized unit tests for Class1</summary>
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    public partial class Class1Test
    {
        /// <summary>Test stub for SelectSX(Int32)</summary>
        [PexMethod]
        public string SelectSXTest(int intYear)
        {
            string result = Class1.SelectSX(intYear);
            return result;
            // TODO: add assertions to method Class1Test.SelectSXTest(Int32)
            //Console.Write(result);
        }


        
    }
}
