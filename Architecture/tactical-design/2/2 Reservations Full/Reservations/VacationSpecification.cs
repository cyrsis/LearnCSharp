using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class VacationSpecification
    {
        private IList<IVacationPart> parts;

        public VacationSpecification(IList<IVacationPart> parts)
        {
            // TODO: Complete member initialization
            this.parts = parts;
        }
    }
}
