using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadQuantity { get; set; }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
      BreadPrice = 0;
    }

    public int BreadCost()
    {
      for (int i = 1; i <= BreadQuantity; i++)
      {
        if (i % 3 != 0)
        {
          BreadPrice += 5;
        }
      }
      return BreadPrice;
    }
  }
}