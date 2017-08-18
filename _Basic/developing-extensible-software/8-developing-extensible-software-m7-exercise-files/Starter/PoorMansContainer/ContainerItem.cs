using System;
using System.Collections.Generic;
using System.Linq;

namespace PoorMansContainer
{
    public class ContainerItem
    {
        public Type AbstractionType { get; set; }
        public Type ConcreteType { get; set; }
    }
}
