using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class LinqReEvaluationExample
    {
        [TestMethod]
        public void WithReEvaluation()
        {
            var nums = new List<int> {1, 2, 3, 4};

            var q = from n in nums
                    select new
                               {
                                   Number = n,
                                   ExecutionTime = DateTime.Now.ToString("mm:ss:fff")
                               };

            Debug.WriteLine("1st enumeration");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }

            Debug.WriteLine("2nd enumeration");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }            
        }


        [TestMethod]
        public void WithoutReEvaluation()
        {
            var nums = new List<int> { 1, 2, 3, 4 };

            var q = (from n in nums
                     select new
                                {
                                    Number = n,
                                    ExecutionTime = DateTime.Now.ToString("mm:ss:fff")
                                }).ToList();

            Debug.WriteLine("1st enumeration");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }

            Debug.WriteLine("2nd enumeration");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }
        }
    }
}
