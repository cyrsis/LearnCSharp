using Sixeyed.CarValet.Services.Entities;
using Sixeyed.CarValet.Services.Repositories;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using data = Sixeyed.CarValet.Entities;

namespace Sixeyed.CarValet.Services
{
    [ServiceContract]
    public class ContentService 
    {
        [OperationContract]
        public IEnumerable<ContentItem> GetItems(string contentCode)
        {
            var items = Repository.Content.GetItems(contentCode);
            return items.ConvertAll<ContentItem>(new Converter<data.ContentItem, ContentItem>(ContentItem.FromEntity));
        }
    }
}
