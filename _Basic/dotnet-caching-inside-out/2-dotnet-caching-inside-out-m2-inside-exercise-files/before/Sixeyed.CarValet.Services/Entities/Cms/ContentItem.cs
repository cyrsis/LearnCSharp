using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using data = Sixeyed.CarValet.Entities;

namespace Sixeyed.CarValet.Services.Entities
{
    [DataContract]
    public class ContentItem
    {
        [DataMember]
        public int Index { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public bool IsHtml { get; set; }

        public static ContentItem FromEntity(data.ContentItem item)
        {
            return new ContentItem()
            {
                Index = item.Index,
                IsHtml = item.IsHtml,
                Value = item.Value
            };
        }
    }
}