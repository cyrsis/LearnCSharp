using System;
using System.Collections.Generic;

namespace Cubo.Core.DTO
{
    public class BucketDTO
    {
        public string Name { get; set; }
        public IList<string> Items { get; set; }
        public DateTime CreatedAt { get; set; }           
    }
}