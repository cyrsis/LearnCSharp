using System;
using System.Collections.Generic;

namespace Sixeyed.Disposable.DomainConsoleApp.Domain.Model
{
    public partial class BookLine
    {
        public int Id { get; set; }
        public int BookFeedId { get; set; }
        public int LineNumber { get; set; }
        public int WordCount { get; set; }
        public string Excerpt { get; set; }
        public virtual BookFeed BookFeed { get; set; }
    }
}
