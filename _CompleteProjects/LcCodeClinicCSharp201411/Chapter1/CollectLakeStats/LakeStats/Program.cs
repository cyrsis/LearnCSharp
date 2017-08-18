using System;
namespace LakeStats
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare local date variables
            DateTime startDate;
            DateTime endDate;

            try
            {
                switch (args.Length)
                {
                    case 1:
                        //Treat 1 arg as both start and end date
                        startDate = DateTime.Parse(args[0]);
                        endDate = DateTime.Parse(args[0]);
                        break;
                    case 2:
                        //Treat 2 args as start and end dates
                        startDate = DateTime.Parse(args[0]);
                        endDate = DateTime.Parse(args[1]);
                        break;
                    default:
                        //If wrong number of args, display usage hints and exit
                        DisplayUsageHints();
                        return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType() + ": " + e.Message);
                Console.WriteLine("--------");
                DisplayUsageHints();
                return;
            }

            //Check that dates either match, or start is before end
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                Console.WriteLine("End date can't be before start date");
                return;
            }

            //Date range is set; get the data
            DateTime thisDate = startDate;
            FeedManager fm = new FeedManager();

            //Loop from start to end date
            while (!thisDate.Equals(endDate.AddDays(1)))
            {
                try
                {
                    FeedResult windResult = fm.GetData(thisDate, FeedManager.WIND_SPEED);
                    Console.WriteLine("Wind: " + windResult);

                    FeedResult baroResult = fm.GetData(thisDate, FeedManager.BARO_PRESSURE);
                    Console.WriteLine("Baro: " + baroResult);

                    FeedResult airTempResult = fm.GetData(thisDate, FeedManager.AIR_TEMP);
                    Console.WriteLine("Temp: " + airTempResult);

                    Console.WriteLine("---------");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType() + ": " + e.Message);
                }

                thisDate = thisDate.AddDays(1);
            }
        }

        private static void DisplayUsageHints()
        {
            Console.WriteLine("Usage  : LakeStats startdate [enddate]");
            Console.WriteLine("Example: LakeStats 2013-01-01 2013-01-07");
        }
    }
}
