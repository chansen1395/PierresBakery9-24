using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryQuantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
      PastryPrice = 0;
    }

    public int PastryCost()
    {
      for (int i = 1; i <= PastryQuantity; i++)
      {
        if (i % 3 != 0)
        {
          PastryPrice += 2;
        }
        else
        {
          PastryPrice += 1;
        }
      }
      return PastryPrice;
    }
  }
}