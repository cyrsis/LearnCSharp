using System;
using System.Collections.Generic;
using System.Linq;

namespace DataManager
{

    class FeedManager
    {
        public const string WIND_SPEED = "Wind_Speed";
        public const string BARO_PRESSURE = "Barometric_Press";
        public const string AIR_TEMP = "Air_Temp";

        private const string BASE_URL = "http://lpo.dt.navy.mil/data/DM/";

        List<double> values;
        CacheManager cacheManager;

        public FeedResult GetData(DateTime startDate, DateTime endDate, string dataType)
        {
            //Initialize variables
            cacheManager = new CacheManager();
            values = new List<double>();
            List<string> lines;
            FeedResult result = new FeedResult();

            //First text lines from cache for the range of requested dates
            lines = cacheManager.GetDataFromCache(startDate, endDate, dataType);

            //If any requested date isn't found, the cache manager throws 
            //an exception that bubbles up LakeStatsService.GetLakeStats()
            //If we get here, process the lines of text
            foreach (string line in lines)
            {
                //Get the 3rd item in the list, add to arraylist
                char[] separators = new char[] { ' ' };
                string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                values.Add(Convert.ToDouble(words[2]));
            }

            //Now calculate and package the results
            //Start with average, rounded to 2 decimals.
            result.mean = values.Average();

            //Calculate the median value; first sort the values in ascending order
            values.Sort();

            //Get the median index as a double
            double medianIndex = (double)(values.Count - 1) / 2;

            //Check whether median index is fractional or whole, get the value
            if (Math.Truncate(medianIndex) == medianIndex)
            {
                result.median = values[Convert.ToInt32(medianIndex)];
            }
            else
            {
                int lowIndex = (Int32)Math.Truncate(medianIndex);
                int highIndex = lowIndex + 1;
                result.median = ((values[lowIndex] + values[highIndex]) / 2);
            }

            return result;

        }
    }

}
