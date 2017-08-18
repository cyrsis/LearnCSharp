using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;
using System;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public interface IBookFeedRepository : IDisposable
    {
        BookFeed Get(int id);
        BookFeed Get(string path);
        void Add(BookFeed bookFeed);
        void Save();
    }
}