using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod01_Finalization
{
    class File
    {
        private Handle _handle;

        public File(string fileName)
        {
            _handle = FileUtilities.CreateOrOpenFile(fileName);
        }

        // to get a clean stack trace when the exception occurs
        [MethodImpl(MethodImplOptions.NoInlining)]
        public byte[] Read(uint count)
        {
            Handle h = _handle;
            return FileUtilities.Read(h, count);
        }

        ~File()
        {
            _handle.Close();
        }
    }
}
