using System;

namespace Demo
{
    public class Location : IDisposable
    {
        ManuallyImplemented _another = new ManuallyImplemented();

        public int Altitude { get; set; }
        public int Lat { get; set; }
        public int Long { get; set; }

        public void Dispose()
        {
            // This has to be empty of code
        }

        #region Custom dispose code
        private void DisposeManaged()
        {
            // Custom code to dispose of managed resources
        }

        private void DisposeUnmanaged()
        {
            // Custom code to dispose of unmanaged resources
        } 
        #endregion
    }
}