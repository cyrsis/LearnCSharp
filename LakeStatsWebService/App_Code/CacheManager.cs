using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace DataManager
{
    class CacheManager
    {
        private string cacheDirectory;

        public void SetDataDirectory(string dataType)
        {

            //Make sure the base cache directory exists
            cacheDirectory = HttpRuntime.AppDomainAppPath + @"Data_Cache\";
            
            //Make sure the data directory exists and set it as current
            string dataDirectory = cacheDirectory + dataType + @"\";
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }
            Directory.SetCurrentDirectory(dataDirectory);

        }

        public List<string> GetDataFromCache(DateTime startDate, DateTime endDate, string dataType)
        {

            //Create a list of strings to collect all the data
            List<string> fileLines = new List<string>();

            //Add 1 to endDate to make looping easier
            endDate = endDate.AddDays(1);
            DateTime currentDate = startDate;

            //Loop through dates and collect data
            while (!currentDate.Equals(endDate))
            {
                string file = GetFileName(currentDate, dataType);

                //If a file doesn't exist for this date and data type, return null
                if (!File.Exists(file))
                {
                    string msg = "File not found: " + dataType + ", " + currentDate.ToShortDateString();
                    throw new Exception(msg);
                }
                else
                {
                    using (FileStream fs = File.OpenRead(file))
                    {
                        StreamReader reader = new StreamReader(fs);
                        while (!reader.EndOfStream)
                        {
                            //get the next available line
                            string line = reader.ReadLine();
                            fileLines.Add(line);
                        }
                    }
                }

                currentDate = currentDate.AddDays(1);
            }

            return fileLines;

        }

        private string GetFileName(DateTime thisDate, string dataType)
        {
            SetDataDirectory(dataType);
            string file = Directory.GetCurrentDirectory() + @"\" +
               thisDate.ToString("yyyy_MM_dd") + ".txt";
            return file;
        }

    }
}
