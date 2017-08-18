using System;
namespace Sixeyed.Disposable.DomainConsoleApp
{
    public interface IBookFeedRunner : IDisposable
    {
        void Start();
    }
}