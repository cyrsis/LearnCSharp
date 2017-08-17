using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class SystemEnvironmentExample
    {

        [TestMethod]
        public void SystemRelatedInfo()
        {
            var envVars = System.Environment.GetEnvironmentVariables();
            var envPathVar = envVars["Path"];

            var is64BitOs = Environment.Is64BitOperatingSystem;
            var is64BitProc = Environment.Is64BitProcess;
            var numberOfProcs = Environment.ProcessorCount;
            var pageSize = Environment.SystemPageSize;
            var clrRuntimeVersion= Environment.Version;
            var currEnvNewLineString = Environment.NewLine;
        }


        [TestMethod]
        public void DirectoryRelatedInfo()
        {                        
            var currentWorkingDir = Environment.CurrentDirectory;

            var desktopDir = Environment.GetFolderPath(
                Environment.SpecialFolder.DesktopDirectory);

            var fontsDir = Environment.GetFolderPath(
                Environment.SpecialFolder.Fonts);
            
            var myDocsDir = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            var usersStartupDir = Environment.GetFolderPath(
                Environment.SpecialFolder.Startup);

            var drives = Environment.GetLogicalDrives();
            
            var sysDir = Environment.SystemDirectory;
        }


    }
}
