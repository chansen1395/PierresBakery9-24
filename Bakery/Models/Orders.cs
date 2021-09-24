using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public class Bread
  {
    private int _breadPrice;
    private int _breadQuantity;

    public int BreadOrder
    {
      get 
      { 
        _breadPrice = 0;
        for (int i = 1; i <= _breadQuantity; i++)
        {
          if (i % 3 != 0)
          {
            _breadPrice += 5;
          }
        }
        return _breadPrice;
      }
      set { _breadQuantity = value; }
    }
    
  }

  public class Pastry
  {
    private int _pastryPrice;
    private int _pastryQuantity;

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
