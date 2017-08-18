using Sixeyed.CarValet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Services.Repositories
{
    public class ContentRepository : IRepository
    {
        public List<ContentItem> GetItems(string contentCode)
        {
            var items = new List<ContentItem>();
            using (var context = new ContentEntities())
            {
                var content = context.Contents.FirstOrDefault(x => x.ContentCode == contentCode);
                items.AddRange(content.ContentItems);
            }
            return items;
        }
    }
}