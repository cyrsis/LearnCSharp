﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    static class CommonMathDynamic
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            dynamic result = a + b;
            return result;
        }
    }
}
