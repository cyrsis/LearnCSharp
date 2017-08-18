using System;
using System.IO;
using System.Threading;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public class FileArchiver : IFileArchiver
    {
        public void Start(string path, string filter, Action<string> onFileCreated)
        {
            var fileSystemWatcher = new FileSystemWatcher(path, filter);
            fileSystemWatcher.Created += (x, y) =>
                {
                    //HACK - let the file write finish:
                    Thread.Sleep(1000);
                    Console.WriteLine("New file created: " + y.Name);
                    onFileCreated(y.FullPath);
                };
            fileSystemWatcher.EnableRaisingEvents = true;
        }
    }
}
