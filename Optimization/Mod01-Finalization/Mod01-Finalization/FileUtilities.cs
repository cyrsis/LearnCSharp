using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod01_Finalization
{
    class FileUtilities
    {
        public static Handle CreateOrOpenFile(string fileName)
        {
            IntPtr handle = NativeMethods.CreateFile(
                fileName,
                NativeMethods.EFileAccess.GenericRead,
                NativeMethods.EFileShare.None,
                IntPtr.Zero,
                NativeMethods.ECreationDisposition.OpenAlways,
                NativeMethods.EFileAttributes.Normal,
                IntPtr.Zero);
            return new Handle(handle);
        }

        public static byte[] Read(Handle handle, uint count)
        {
            #region Hidden
            GC.Collect();
            GC.WaitForPendingFinalizers();
            #endregion

            byte[] buffer = new byte[count];

            uint bytesRead;
            if (!NativeMethods.ReadFile(handle.Use(), buffer, count, out bytesRead, IntPtr.Zero))
                throw new Win32Exception(Marshal.GetLastWin32Error(), "Error reading from file");

            return buffer;
        }
    }
}
