using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class FileSystemWatcherExample
    {
        [TestMethod]
        public void Example()
        {
            var watcher = new System.IO.FileSystemWatcher();

            watcher.Path = @"c:\temp\watched";

            watcher.Filter = "*.txt";

            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Attributes;

            // FileName   DirectoryName  Attributes        Size
            // LastWrite  LastAccess       CreationTime  Security

            watcher.Changed += FileChanged;
            watcher.Created += FileChanged;
            watcher.Deleted += FileChanged;
            watcher.Renamed += FileRenamed;

            watcher.EnableRaisingEvents = true;

            while (true){}
        }


        void FileRenamed(object sender, RenamedEventArgs e)
        {
            Debug.WriteLine("------FileRenamed---------------------------");

            Debug.WriteLine(e.ChangeType);
            Debug.WriteLine(e.OldName);
            Debug.WriteLine(e.Name);
        }   


        void FileChanged(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine("------FileChanged----------------------------");

            Debug.WriteLine(e.ChangeType);
            Debug.WriteLine(e.Name);
        }
    }  
}