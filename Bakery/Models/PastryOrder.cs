using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    private int _pastryPrice;
    private int _pastryQuantity;

    // Determine Pastry price, every 3rd Pastry is $1
    public int PastryOrder
    {
      get 
      { 
        _pastryPrice = 0;
        for (int i = 1; i <= _pastryQuantity; i++)
        {
          if (i % 3 != 0)
          {
            _pastryPrice += 2;
          }
          else
          {
            _pastryPrice += 1;
          }
        }
        return _pastryPrice;
      }
      set { _pastryQuantity = value; }
    }
  }
}