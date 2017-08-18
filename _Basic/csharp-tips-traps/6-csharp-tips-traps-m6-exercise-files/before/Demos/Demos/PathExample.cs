using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class PathExample
    {
        [TestMethod]
        public void CreatingPathManually()
        {
            var drive = "c:";
            var dir = @"temp\pspathdemo\";
            var file = "test.txt";

            var fullPath = drive;

            if (! drive.EndsWith(@"\"))
            {
                fullPath += @"\";
            }

            fullPath += dir;

            if (!dir.EndsWith(@"\"))
            {
                fullPath += @"\";
            }

            fullPath += file;
        }






        [TestMethod]
        public void UsingPathCombine()
        {
            var drive = "c:";
            var dir = @"temp\pspathdemo\";
            var file = "test.txt";

            var fullPath = System.IO.Path.Combine(drive, dir, file);
            
            drive = @"c:\";
     
            fullPath = Path.Combine(drive, dir, file);
        }








        [TestMethod]
        public void UsefulPathMethods()
        {
            var path = @"c:\temp\pspathdemo\test.txt";

            path = Path.ChangeExtension(path, "bak");

            var dirName = Path.GetDirectoryName(path);

            var ext = Path.GetExtension(path);

            var file = Path.GetFileName(path);
            
            var fileNoExt = Path.GetFileNameWithoutExtension(path);

            bool hasExt = Path.HasExtension(path);
        }







        [TestMethod]
        public void UsefulGeneralMethods()
        {
            var invalidNameChars = Path.GetInvalidFileNameChars();

            var rndFileName = Path.GetRandomFileName();

            var rndTempFile = Path.GetTempFileName();

            var userTempPath = Path.GetTempPath();

            char platformSpecificDirSeparater = Path.DirectorySeparatorChar;
        }








        [TestMethod]
        public void PathCombinePeculiarities()
        {
            // combining "absolute" paths
            var result = Path.Combine(@"\data", @"c:\temp");

            result = Path.Combine(@"c:\temp", @"\data"); //  \data is considered an absolute path 

            result = Path.Combine(@"c:\temp", @"data");

            result = Path.Combine(@"c:\temp", @"\data".TrimStart(Path.DirectorySeparatorChar));



            // empty strings
            result = Path.Combine("", @"c:\data");
            result = Path.Combine(@"x:\data", "");



            // using ".." to refer to parent dir
            result = Path.Combine(@"c:\temp\data", @"..");
           
           
            result = Path.GetFullPath(result);
            // if path actually exists we must have permission to obtain path info for it           
        }

    }
}
