using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sixeyed.Core.Containers;

namespace Sixeyed.CarValet.Services.Repositories
{
    public static class Repository
    {
        public static VehicleRepository Vehicle
        {
            get { return new VehicleRepository(); }
        }

        public static ContentRepository Content
        {
            get { return new ContentRepository(); }
        }
    }
}