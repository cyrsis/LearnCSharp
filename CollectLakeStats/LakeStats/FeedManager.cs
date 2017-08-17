using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace LakeStats
{

    class FeedManager
    {
        public const string WIND_SPEED = "Wind_Speed";
        public const string BARO_PRESSURE = "Barometric_Press";
        public const string AIR_TEMP = "Air_Temp";

        private const string BASE_URL = "http://lpo.dt.navy.mil/data/DM/";

        List<double> values;
        CacheManager cacheManager;

        public FeedManager()
        {
            cacheManager = new CacheManager();
        }
        
        public FeedResult GetData(DateTime thisDate, string dataType)
        {
            //Initialize variables
            values = new List<double>();
            List<string> lines;
            FeedResult result = new FeedResult();
            
            //First try to get text lines from cache
            lines = cacheManager.getDataFromCache(thisDate, dataType);
            //If not found, pull from the web feed
            if (lines == null)
            {
                Console.WriteLine("Downloading: " + thisDate.ToString("MM/dd/yyyy"));
                lines = GetDataFromURL(thisDate, dataType);
            }
            else
            {
                Console.WriteLine("From cache : " + thisDate.ToString("MM/dd/yyyy"));
            }

            //Process the lines of text
            foreach (string line in lines)
            {
                //Get the 3rd item in the list, add to arraylist
                char[] separators = new char[] { ' ' };
                string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                values.Add(Convert.ToDouble(words[2]));

            }

            //Report the number of items in the list
            result.count = values.Count;

            //Now calculate and package the results
            //Start with mean, rounded to 2 decimals.
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

        private List<string> GetDataFromURL(DateTime thisDate, string dataType)
        {
            //Build URL from base + year + formatted date
            string feedURL = BASE_URL +
                thisDate.ToString("yyyy") + "/" +
                thisDate.ToString("yyyy_MM_dd") + "/" +
                dataType;

            WebResponse response = null;
            List<string> lines;

            try
            {
                lines = new List<string>();
                WebRequest request = WebRequest.Create(feedURL);
                response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StringWriter sw = new StringWriter();

                using (StreamReader reader = new StreamReader(dataStream))
                {
                    while (!reader.EndOfStream)
                    {
                        //get the next available line
                        string line = reader.ReadLine();
                        lines.Add(line);
                        sw.WriteLine(line);
                    }

                }
                cacheManager.writeFileToCache(sw.ToString(), thisDate, dataType);
            }
            catch (Exception e)
            {
                // If we get here, something went wrong - throw the exception to the calling scope
                throw (e);
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            return lines;
        }
    }
}
