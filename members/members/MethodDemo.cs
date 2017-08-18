using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace members
{
    class MethodDemo
    {
        public MethodDemo()
        {
            WriteAsBytes(32, 42, 255, Int16.MaxValue, Int32.MaxValue);
            WriteAsBytes(new double[] { 2.0, 4.1, 6.3, 7.9 });
        }

        public void WriteAsBytes(params double[] values)
        {
            Debug.WriteLine("Writing doubles");
            foreach (int value in values)
            {
                byte[] bytes = BitConverter.GetBytes(value);
                foreach (byte b in bytes)
                {
                    string message = String.Format("0x{0:X2} ", b);
                    Debug.Write(message);
                }

                Debug.WriteLine("");
            }
        }       

        public void WriteAsBytes(params int[] values)
        {
            Debug.WriteLine("Writing integers");

            foreach (int value in values)
            {
                byte[] bytes = BitConverter.GetBytes(value);
                foreach (byte b in bytes)
                {
                    string message = String.Format("0x{0:X2} ", b);
                    Debug.Write(message);
                }

                Debug.WriteLine("");
            }
        }
    }
}
