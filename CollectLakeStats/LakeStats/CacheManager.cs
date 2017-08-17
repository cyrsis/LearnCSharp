using System;
using System.Collections.Generic;
using System.IO;

namespace LakeStats
{
    class CacheManager
    {
        private const string CACHEDIRECTORY = @"c:\lakestats\cachedir\";
        
        public void setDataDirectory(string dataType)
        {
            //Make sure the base cache directory exists
            if (!Directory.Exists(CACHEDIRECTORY))
            {
                Directory.CreateDirectory(CACHEDIRECTORY);
            }
        
            //Set the directory for the current data type
            string dataDirectory = CACHEDIRECTORY + dataType + @"\";
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }
            Directory.SetCurrentDirectory(dataDirectory);

        }

        public void writeFileToCache(string content, DateTime thisDate, string dataType)
        {
            string file = getFileName(thisDate, dataType);
            using (StreamWriter outfile = new StreamWriter(file))
            {
                outfile.Write(content);
            }
        }

        public List<string> getDataFromCache(DateTime thisDate, string dataType)
        {
            string file = getFileName(thisDate, dataType);

            if (!File.Exists(file))
            {
                return null;
            }
            else
            {
                List<string> list = new List<string>();
                using (FileStream fs = File.OpenRead(file))
                {
                    StreamReader reader = new StreamReader(fs);
                    while (!reader.EndOfStream)
                    {
                        //get the next available line
                        string line = reader.ReadLine();
                        list.Add(line);
                    }
                    return list;
                }
            }

        }

        private string getFileName(DateTime thisDate, string dataType) {
            setDataDirectory(dataType);
            string file = Directory.GetCurrentDirectory() + @"\" + 
               thisDate.ToString("yyyy_MM_dd") + ".txt";
            return file;
        }

    }
}
