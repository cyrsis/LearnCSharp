using System;
using System.Collections.Generic;

namespace SampleAssembly
{
    // Version 2.0
    public class SampleClass
    {
        private DateTime dataDate;
        private List<string> internalCache;

        public string DataTime
        {
            get { return dataDate.ToString("HH:mm:ss"); }
        }

        public List<string> CachedItems
        {
            get
            {
                if (internalCache == null || DateTime.Now - dataDate > TimeSpan.FromSeconds(5))
                    RefreshCache();
                return internalCache;
            }
        }

        private void RefreshCache()
        {
            dataDate = DateTime.Now;
            if (internalCache == null)
                internalCache = new List<string>();
            internalCache.Add(string.Format("Time: {0}", DataTime));
        }
    }
}
