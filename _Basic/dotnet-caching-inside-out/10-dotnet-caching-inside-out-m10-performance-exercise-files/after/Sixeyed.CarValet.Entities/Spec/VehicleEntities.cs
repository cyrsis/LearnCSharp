using Sixeyed.CarValet.Entities.Spec;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.CarValet.Entities
{
    public partial class VehicleEntities : IVehicleEntities
    {

        IEnumerable<Make> IVehicleEntities.Makes
        {
            get
            {
                return Makes;
            }
            set
            {
                Makes = value as DbSet<Make>;
            }
        }
    }
}
