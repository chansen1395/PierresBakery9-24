using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    private int _breadPrice { get; set; }
    private int _breadQuantity { get; set; }

    public Bread(int breadQuantity)
    {
      _breadQuantity = breadQuantity;
      _breadPrice = 0;
    }

    public int BreadPrice()
    {
      for (int i = 1; i <= _breadQuantity; i++)
      {
        if (i % 3 != 0)
        {
          _breadPrice += 5;
        }
      }
      return _breadPrice;
    }
  }
}
    // private static List<Category> _instances = new List<Category> {};
    // public string Name { get; set; }
    // public int Id { get; }
    // public List<Item> Items { get; set; }

    // public Category(string categoryName)
    // {
    //   Name = categoryName;
    //   _instances.Add(this);
    //   Id = _instances.Count;
    //   Items = new List<Item>{};
    // }
    // Determine Bread price, every 3rd loaf is free
  //   public int BreadOrder
  //   {
  //     get 
  //     { 
  //       _breadPrice = 0;
  //       for (int i = 1; i <= _breadQuantity; i++)
  //       {
  //         if (i % 3 != 0)
  //         {
  //           _breadPrice += 5;
  //         }
  //       }
  //       return _breadPrice;
  //     }
  //     set { _breadQuantity = value; }
  //   }
  // }