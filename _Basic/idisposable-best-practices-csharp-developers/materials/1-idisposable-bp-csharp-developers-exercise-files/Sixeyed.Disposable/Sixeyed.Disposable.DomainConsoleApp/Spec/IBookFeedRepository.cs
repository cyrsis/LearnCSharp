using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public interface IBookFeedRepository
    {
        BookFeed Get(int id);
        BookFeed Get(string path);
        void Add(BookFeed bookFeed);
        void Save();
    }
}