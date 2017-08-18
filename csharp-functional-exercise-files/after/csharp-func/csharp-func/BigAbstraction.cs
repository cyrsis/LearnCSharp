using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace csharp_func
{
    public class BigFileManager : IEnumerable<BlobFile>
    {
        private List<BlobFile> _files;

        public BigFileManager(string path)
        {
            _files = new List<BlobFile>();
        }
        
        public IEnumerable<BlobFile> SearchFiles(Regex pattern)
        {
            return _files.Where(f => false)
                         .ToArray();
        }

        public BlobFile AddFile(string name, byte[] content)
        {
            FileAdded(this, null);
            return null;
        }

        public int Count
        {
            get { return 0; }
        }

        public event EventHandler<FileChangeEventArgs> FileAdded;

        public IEnumerator<BlobFile> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class FileChangeEventArgs : EventArgs
    {
        public string Name { get; set; }
    }

    public class BlobFile
    {
        
    }
}