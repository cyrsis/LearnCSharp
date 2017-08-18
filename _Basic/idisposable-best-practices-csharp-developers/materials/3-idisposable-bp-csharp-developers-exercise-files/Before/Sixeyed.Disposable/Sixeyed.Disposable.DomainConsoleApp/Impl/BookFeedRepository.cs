using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sixeyed.Disposable.DomainConsoleApp.Domain;
using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    public class BookFeedRepository : IBookFeedRepository
    {
        private BookFeedContext _context;

        public BookFeedRepository()
        {
            _context = new BookFeedContext();
        }

        public BookFeed Get(int id)
        {
            return _context.BookFeeds.Find(id);
        }

        public BookFeed Get(string path)
        {
            return _context.BookFeeds.FirstOrDefault(x => x.Path == path);
        }

        public void Add(BookFeed bookFeed)
        {
            _context.BookFeeds.Add(bookFeed);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
