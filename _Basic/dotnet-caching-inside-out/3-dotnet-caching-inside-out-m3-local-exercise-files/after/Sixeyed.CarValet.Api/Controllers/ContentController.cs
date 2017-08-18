using Sixeyed.CarValet.Api.Models;
using Sixeyed.CarValet.Api.ServiceAgents;
using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Content;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Sixeyed.CarValet.Api.Controllers
{
    public class ContentController : ApiController
    {
        public IEnumerable<ContentModel> GetByCode(string contentCode)
        {
            var response = ServiceAgent.Content.GetItems(contentCode);
            var items = new List<ContentItem>(response);
            return items.ConvertAll<ContentModel>(new Converter<ContentItem, ContentModel>(ContentModel.FromServiceEntity));
        }
    }
}
