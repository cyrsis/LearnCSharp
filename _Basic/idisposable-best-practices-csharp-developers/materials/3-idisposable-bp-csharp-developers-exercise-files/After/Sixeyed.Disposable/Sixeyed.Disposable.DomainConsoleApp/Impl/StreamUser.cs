using System.IO;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public class StreamUser : IStreamUser
    {
        public void CopyFile(string sourcePath, string targetPath)
        {
            using (var inputStream = File.OpenRead(sourcePath))
            {
                using (var outputStream = File.Create(targetPath))
                {
                    inputStream.CopyTo(outputStream);
                }
            }
        }
    }
}
