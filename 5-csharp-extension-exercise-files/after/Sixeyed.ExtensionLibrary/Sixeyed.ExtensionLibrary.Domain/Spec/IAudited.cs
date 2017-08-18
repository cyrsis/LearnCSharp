using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.ExtensionLibrary.Domain.Model
{
    public interface IAudited
    {
        Audit Audit { get; set; }
    }
}
