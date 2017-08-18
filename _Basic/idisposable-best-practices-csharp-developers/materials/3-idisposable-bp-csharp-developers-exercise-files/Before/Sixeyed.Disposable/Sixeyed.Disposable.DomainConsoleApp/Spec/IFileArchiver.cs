using System;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public interface IFileArchiver
    {
        void Start(string path, string filter, Action<string> onFileCreated);
    }
}