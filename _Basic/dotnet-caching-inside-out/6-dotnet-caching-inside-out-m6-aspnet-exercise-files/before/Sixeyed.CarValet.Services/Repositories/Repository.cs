using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sixeyed.Core.Containers;

namespace Sixeyed.CarValet.Services.Repositories
{
    public static class Repository
    {
        static Repository()
        {
            Container.Register<VehicleRepository>(Lifetime.Singleton);
        }

        public static VehicleRepository Vehicle
        {
            get { return Container.Get<VehicleRepository>(); }
        }

        public static ContentRepository Content
        {
            get { return new ContentRepository(); }
        }
    }
}