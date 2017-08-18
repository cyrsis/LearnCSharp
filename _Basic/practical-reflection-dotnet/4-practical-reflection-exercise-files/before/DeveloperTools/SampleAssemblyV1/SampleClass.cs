using System;
using System.Collections.Generic;

namespace SampleAssembly
{
    // Version 1.0
    public class SampleClass
    {
        private DateTime dataDate;
        private List<string> cachedItems;

        public string DataTime
        {
            get { return dataDate.ToString("HH:mm:ss"); }
        }

        public List<string> CachedItems
        {
            get
            {
                if (cachedItems.Count == 0 || DateTime.Now - dataDate > TimeSpan.FromSeconds(5))
                    RefreshCache();
                return cachedItems;
            }
        }

        public SampleClass()
        {
            cachedItems = new List<string>();
            RefreshCache();
        }

        private void RefreshCache()
        {
            dataDate = DateTime.Now;
            cachedItems.Add(string.Format("Time: {0}", DataTime));
        }
    }
}
