using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.CarValet.Entities.Spec
{
    public interface IVehicleEntities
    {
        IEnumerable<Make> Makes { get; set; }

        DbContextConfiguration Configuration { get; }
    }
}
