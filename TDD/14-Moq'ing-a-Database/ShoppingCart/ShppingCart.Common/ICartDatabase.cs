﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Common
{
    public interface ICartDatabase
    {
        long SaveCart(Cart cart);
    }
}
