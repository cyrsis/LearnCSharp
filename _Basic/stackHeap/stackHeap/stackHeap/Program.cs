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
            int score = 95;
            int score2 = score;
            Console.WriteLine("score = {0}, score2 = {1}", score, score2);

            Report report = new Report()
            {
                Title = "First Report",
                Desc = "This is the first report",
                Pages = 11
            };
            //Report report2 = report;
            //Console.WriteLine(report.Display());
            //Console.WriteLine(report2.Display());

            //report2.Pages = 999;

            //Console.WriteLine(report.Display());
            //Console.WriteLine(report2.Display());

            Console.WriteLine("score = " + score);
            Console.WriteLine("object pages = " + report.Pages);
            ProcessIt(score, report);
            Console.WriteLine("score = " + score);
            Console.WriteLine("object pages = " + report.Pages);


            Console.ReadLine();
        }

        static void ProcessIt(int s, Report r)
        {
            s = 1111;
            r.Pages = 11111;
        }

    }

    struct Report
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Pages { get; set; }

        public string Display()
        {
            return String.Format("{0}: {1}, pp. {2}", Title, Desc, Pages);
        }

    }

}
