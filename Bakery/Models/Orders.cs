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
        _breadPrice = _breadQuantity * 5;
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
