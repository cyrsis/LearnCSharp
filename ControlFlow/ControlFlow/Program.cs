using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ControlFlow
{

    public class Employee
    {
        private string _name;

        public string Name
        {
            get
            {
                return Name; // bug!! bug!!
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoWork(); // creates exception
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Caught a NIE in Main");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.TargetSite);
            }

            NestedBranching();
            Switching(Environment.SpecialFolder.InternetCache);
            ForEach();
            Yielding();

            //string name = new Employee().Name;  // creates StackOverflowException
        }

        private static void DoWork()
        {
            try
            {

                DoSomeMoreWork();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caught a NIE in DoWork");
            }
            
            
            Console.WriteLine("DoWork");
        }

        private static void DoSomeMoreWork()
        {
            throw new NotImplementedException();
            Console.WriteLine("DoMoreWork...");
        }



        private static void NestedBranching()
        {
            if (Environment.ProcessorCount < 2)
            {
                var text =
                    Environment.Is64BitProcess ?
                        "Single processor, 64 bit process" :
                        "Single processor, 32 bit process";
            }
        }

        private static void Switching(Environment.SpecialFolder folder)
        {
            switch (folder)
            {
                case Environment.SpecialFolder.CommonMusic:
                        Console.WriteLine("Looks like music folder!");
                        break;
                case Environment.SpecialFolder.CommonPictures:
                case Environment.SpecialFolder.CommonVideos:
                    Console.WriteLine("Looks like a media folder!");
                    break;
                
                default:
                    Console.WriteLine("Probably just boring data");
                    break;
            }
        }

        private static void ForEach()
        {            
            
            ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }


        static void Yielding()
        {
            foreach (int n in GenerateSomeNumbers())
            {
                if (n == 10)
                {
                    break;
                }
                Console.WriteLine(n);                
            }
        }

        private static IEnumerable GenerateSomeNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            Console.WriteLine("Making more numbers");

            yield return 100;
            yield break;
            yield return 200;
        }



        
    }
}
