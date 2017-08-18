using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Sixeyed.Disposable.DomainConsoleApp.Domain.Mapping;
using Sixeyed.Disposable.DomainConsoleApp.Domain.Model;

namespace Sixeyed.Disposable.DomainConsoleApp.Domain
{
    public partial class BookFeedContext : DbContext
    {
        static BookFeedContext()
        {
            Database.SetInitializer<BookFeedContext>(null);
        }

        public BookFeedContext()
            : base("Name=Books")
        {
        }

        public DbSet<BookFeed> BookFeeds { get; set; }
        public DbSet<BookLine> BookLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookFeedMap());
            modelBuilder.Configurations.Add(new BookLineMap());
        }
    }
}
