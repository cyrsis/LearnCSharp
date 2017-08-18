using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class WorkingWithUris
    {
        [TestMethod]
        public void Creating()
        {
            var pluralsight = new Uri("http://pluralsight.com");

            var localFile = new Uri(@"c:\temp\somefile.bin");

            var uncLanFile = new Uri(@"\\somepc\shareddocs\somefile.txt");


            var builder = new UriBuilder();
            builder.Scheme = "http";
            builder.Host = "dontcodetired.com";
            builder.Path = "blog";

            var dct = builder.Uri;
        }











        [TestMethod]
        public void CreatingRelativeAndAbsolute()
        {
            var dct = new Uri("http://dontcodetired.com"); // assumes absolute
            dct = new Uri("http://dontcodetired.com", UriKind.Absolute);


            // var relativeUri = new Uri("/index.html"); // exception - assumes absolute
            var relativeUri = new Uri("/blog/", UriKind.Relative);


            var relativeOrAbsolute = new Uri("/blog/", UriKind.RelativeOrAbsolute);


            var baseUri = new Uri("http://dontcodetired.com"); // assumes absolute
            var fullUri = new Uri(baseUri, relativeUri);
        }









        [TestMethod]
        public void UriParts()
        {
            var dct = new Uri("http://dontcodetired.com:8080/blog/?tag=/design#foo");

            var scheme = dct.Scheme;

            var authority = dct.Authority;
            var authorityHost = dct.Host;
            var authorityPort = dct.Port;

            var pathAndQuery = dct.PathAndQuery;
            var absolutePath = dct.AbsolutePath;
            var query = dct.Query;

            var fragment = dct.Fragment;
        }








        [TestMethod]
        public void ModifyingAUri()
        {
            var dct = new Uri("http://dontcodetired.com:8080/blog/?tag=/design#foo");

            var builder = new UriBuilder(dct);
            builder.Port = 8081;

            dct = builder.Uri;
        }









        [TestMethod]
        public void SomeOtherUsefulThings()
        {
            var dct = new Uri("http://dontcodetired.com/blog/");            
            var isDefaultPort = dct.IsDefaultPort;
            var isFile = dct.IsFile;
            var isUnc = dct.IsUnc;


            var localFile = new Uri("file:///c:/temp/somefile.bin");
            var path = localFile.LocalPath;
        }
    }  
}