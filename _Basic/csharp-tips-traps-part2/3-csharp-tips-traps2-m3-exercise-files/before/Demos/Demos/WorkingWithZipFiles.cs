using System.IO.Compression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class WorkingWithZipFiles
    {

        [TestMethod]
        public void CreatingFromADirectory()
        {
           ZipFile.CreateFromDirectory(@"C:\Temp\psfiledemo\OriginalFiles", 
                                                        @"C:\Temp\psfiledemo\JustFiles.zip");
        }











        [TestMethod]
        public void CreatingFromADirectoryWithSubdir()
        {
            ZipFile.CreateFromDirectory(@"C:\Temp\psfiledemo\OriginalFiles",
                                                          @"C:\Temp\psfiledemo\FilesWithDir.zip",
                                                          CompressionLevel.Fastest,
                                                          true);
        }










        [TestMethod]
        public void ExtractingAllFiles()
        {
            ZipFile.ExtractToDirectory(@"C:\Temp\psfiledemo\FilesWithDir.zip",
                                                      @"C:\Temp\psfiledemo\ExtractedFiles");
        }











        [TestMethod]
        public void AddingExtraFiles()
        {
            ZipFile.CreateFromDirectory(@"C:\Temp\psfiledemo\OriginalFiles",
                                                          @"C:\Temp\psfiledemo\AddingAnExtraFile.zip");

            using (ZipArchive zip = ZipFile.Open(@"C:\Temp\psfiledemo\AddingAnExtraFile.zip", 
                                                                     ZipArchiveMode.Update))
            {
                zip.CreateEntryFromFile(@"C:\Temp\psfiledemo\lonefile.txt",
                                                       "lonefile.txt");                
            }
        }







        [TestMethod]
        public void RemovingAFile()
        {
            ZipFile.CreateFromDirectory(@"C:\Temp\psfiledemo\OriginalFiles",
                                                          @"C:\Temp\psfiledemo\RemovingAFile.zip");

            using (ZipArchive zip = ZipFile.Open(@"C:\Temp\psfiledemo\RemovingAFile.zip",
                                                                     ZipArchiveMode.Update))
            {
                var f1 = zip.GetEntry("File1.txt");

                f1.Delete();
            }
        }
    }  
}