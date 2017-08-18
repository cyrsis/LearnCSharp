using Sixeyed.CarValet.Api.ServiceAgents.Wcf.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Api.Models
{
    public class ContentModel
    {
        public int Index { get; set; }

        public string Value { get; set; }

        public bool IsHtml { get; set; }

        public static ContentModel FromServiceEntity(ContentItem item)
        {
            return new ContentModel()
            {
                Index = item.Index,
                IsHtml = item.IsHtml,
                Value = item.Value
            };
        }
    }
}