using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IDisposable
{
    public class CellPhone : IDisposable
    {
        private bool Disposed = false;
        private void FreeResources(bool disposing)
        {
            // If we are already disposed, do nothing.
            if (Disposed) return;
            Disposed = true;

            // If we are being called by Dispose,
            // free managed resources.
            if (disposing)
            {
                // Free managed resources...
            }

            // In either case, free unmanaged resources.
            // Free unmanaged resources...
        }

        public void Dispose()
        {
            FreeResources(true);
            GC.SuppressFinalize(this);
        }

        ~CellPhone()
        {
            FreeResources(false);
        }
    }
}
