using System;
using System.Collections.Generic;

namespace Houses
{
    public interface IPaintingScheduler
    {
        IEnumerable<Tuple<IPainter, double>> Organize(IEnumerable<IPainter> painters,
                                                      double houses);
    }
}
