using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string status = "online";

            //if (status == "online")
            //    Console.WriteLine("synchronizing data");
            //else if (status == "offline")
            //    Console.WriteLine("you are currently offline");
            //else
            //    Console.WriteLine("invalid status: '{0}'", status);

            //switch (status)
            //{
            //    case "online":
            //        Console.WriteLine("synchronizing data");
            //        break;
            //    case "offline":
            //        Console.WriteLine("you are currently offline");
            //        break;
            //    default:
            //        Console.WriteLine("invalid status: '{0}'", status);
            //        break;
            //}   

            Status status = Status.Offline;

            switch (status)
            {
                case Status.Online:
                    Console.WriteLine("on");
                    break;
                case Status.Offline:
                    Console.WriteLine("off");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }



            Console.ReadLine();
        }


        public enum Status
        {
            Online,
            Offline
        }

    }
}
