using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Tester
    {
        public double DoDivide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            if (x == 0)
                throw new MyCustomException("Dividend can't be zero!");
            return x / y;
        }
    }

    public class MyCustomException : Exception
    {
        public MyCustomException(string message) :
            base(message)
        {           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tester t = new Tester();
                double answer = t.DoDivide(12, 4);
                Console.WriteLine("DoDivide(12,4) = {0}", answer);
                answer = t.DoDivide(0, 4);
                Console.WriteLine("DoDivide(0,4) = {0}", answer);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
