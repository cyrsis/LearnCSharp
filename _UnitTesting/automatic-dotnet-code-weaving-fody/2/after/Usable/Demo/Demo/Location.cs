using System;

namespace Demo
{
    public class Location : IDisposable
    {       
        public int Altitude { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }

        public void Dispose()
        {
        }

        private void DisposeManaged()
        {
        }

    }
}