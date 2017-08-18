using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Common.Modules
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommerceModuleAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
