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

            //string reportTitle = "January Report";
            //string reportDescription = "This is the first report";
            //int reportNumberOfPages = 234;

            //string reportTitle2 = "February Report";
            //string reportDescription2 = "This is the second report";
            //int reportNumberOfPages2 = 224;

            //Report report = new Report();
            //report.Title = "January Report";
            //report.Description = "This is the first report";
            //report.NumberOfPages = 123;

            string importString = "January Report;The first report;123;February Report;The second Report;343;March Report;The third report;632;April Report;The fourth report;237";
            List<Report> reports = new List<Report>();
            string[] parts = importString.Split(';');

            for (int i = 0; i < parts.Length; i = i + 3)
            {
                Report report = new Report();
                report.Title = parts[i];
                report.Description = parts[i + 1];
                report.NumberOfPages = Convert.ToInt32(parts[i + 2]);
                reports.Add(report);
            }

            foreach (var report in reports)
            {
                Console.WriteLine(report.Display());
            }



            Console.ReadLine();
        }

    }

    public class Report
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }

        internal string Display()
        {
            if(NumberOfPages > 300)
                return String.Format("{0}: {1}, pp. {2} (LONG REPORT)", Title, Description, NumberOfPages);
            else
                return String.Format("{0}: {1}, pp. {2}", Title, Description, NumberOfPages);
        }
    }


}
