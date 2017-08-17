using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sixeyed.SpecFlowItAll.Domain.Model;

namespace Sixeyed.SpecFlowItAll.Domain.Suppliers.ReorderStrategies
{
    public interface IReorderStrategy
    {
        Supplier Supplier { get; set; }
    
        void Reorder(string productCode);
    }
}
