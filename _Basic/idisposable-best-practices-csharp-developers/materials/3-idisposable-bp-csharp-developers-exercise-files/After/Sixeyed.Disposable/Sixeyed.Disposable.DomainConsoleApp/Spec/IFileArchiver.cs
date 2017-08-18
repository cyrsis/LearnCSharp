using System;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public interface IFileArchiver : IDisposable
    {
        void Start(string path, string filter, Action<string> onFileCreated);
    }
}