using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public class Bread
  {
    private int _breadPrice;
    private int _breadQuantity;

    public int BreadQuantity 
    {
      // get { return _breadPrice; }
      get 
      { 
        _breadPrice = 0;
        // _breadPrice = _breadQuantity * 5;
        // Console.WriteLine(_breadQuantity);
        for (int i = 1; i <= _breadQuantity; i++)
        {
          if (i % 3 != 0)
          {
            _breadPrice += 5;
            // Console.WriteLine(_breadPrice);
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

    public int PastryPrice 
    {
      get { return _pastryPrice; }
      // get 
      // { 
      //   if   
      // }
      set { _pastryPrice = value; }
    }
    
  }
}
