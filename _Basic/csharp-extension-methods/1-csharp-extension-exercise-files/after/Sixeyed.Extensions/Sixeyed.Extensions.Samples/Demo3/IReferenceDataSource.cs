using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo3
{
    public interface IReferenceDataSource
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}
