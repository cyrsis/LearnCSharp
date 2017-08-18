using System;
using System.IO;
using System.Threading;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public class FileArchiver : IFileArchiver
    {
        private FileSystemWatcher _fileSystemWatcher;

        public void Start(string path, string filter, Action<string> onFileCreated)
        {
            _fileSystemWatcher = new FileSystemWatcher(path, filter);
            _fileSystemWatcher.Created += (x, y) =>
                {
                    //HACK - let the file write finish:
                    Thread.Sleep(1000);
                    Console.WriteLine("New file created: " + y.Name);
                    onFileCreated(y.FullPath);
                };
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _fileSystemWatcher != null)
            {
                _fileSystemWatcher.Dispose();
                _fileSystemWatcher = null;
            }
        }
    }
}
