using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod01_Finalization
{
    class Handle
    {
        private IntPtr _handle;

        public Handle(IntPtr handle)
        {
            _handle = handle;
        }

        public IntPtr Use()
        {
            if (IsClosed)
                Console.WriteLine("WARNING: Attempting to use a closed handle.");
            return _handle;
        }

        public void Close()
        {
            NativeMethods.CloseHandle(_handle);
            _handle = IntPtr.Zero;
        }

        public bool IsClosed
        {
            get { return _handle == IntPtr.Zero; }
        }
    }
}
