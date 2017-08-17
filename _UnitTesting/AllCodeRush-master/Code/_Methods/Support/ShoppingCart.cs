using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.Methods
{
  public class ShoppingCart
  {
    private List<Item> items = new List<Item>();
    public List<Item> Items
    {
      get
      {
        return items;
      }
    }
  }
}
