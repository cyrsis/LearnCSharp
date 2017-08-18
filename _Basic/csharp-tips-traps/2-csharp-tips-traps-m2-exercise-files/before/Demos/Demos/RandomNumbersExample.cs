using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class RandomNumbersExample
    {
        [TestMethod]
        public void Wrong()
        {
            var r1 = new Random();
            var r2 = new Random();

            Debug.WriteLine("r1 sequence");
            for (int i = 0; i <5; i++)
            {
                Debug.WriteLine(r1.Next());
            }
            

            Debug.WriteLine("r2 sequence");
            for (int i = 0; i <5; i++)
            {
                Debug.WriteLine(r2.Next());
            }           
        }


        [TestMethod]
        public void Better()
        {
            var r1 = new Random();            

            Debug.WriteLine("r1 sequence");
            for (int i = 0; i < 5; i++)
            {
                Debug.WriteLine(r1.Next());
            }

            Debug.WriteLine("more r1 sequence");
            for (int i = 0; i < 5; i++)
            {
                Debug.WriteLine(r1.Next());
            }
        }


        [TestMethod]
        public void HighSecurity()
        {
            var r = System.Security.Cryptography.RandomNumberGenerator.Create();

            var randomBytes = new byte[4]; // 4 bytes so we can convert to an 32-bit int

            r.GetBytes(randomBytes);

            int rndInt = BitConverter.ToInt32(randomBytes, 0);

            Debug.WriteLine(rndInt);           
        }
    }
}
