using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace CarRental.Business.Bootstrapper
{
    public static class MEFLoader
    {
        public static CompositionContainer Init()
        {
            AggregateCatalog catalog = new AggregateCatalog();

            // add items to catalog here
            
            CompositionContainer container = new CompositionContainer(catalog);

            return container;
        }
    }
}
