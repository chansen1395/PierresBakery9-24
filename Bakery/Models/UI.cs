using System;
using System.Collections.Generic;

namespace UI.Models
{
  public class OrdersUI
  {
    public static int BreadOrderUI()
    {
      // Handle user input errors for Bread, repeat prompt until input is accepted
      Console.WriteLine("Enter the quantity of Bread you would like to purchase:");
      string breadQuantString = Console.ReadLine();
      try
      {
        int breadQuant = Int32.Parse(breadQuantString);
        if (breadQuant < 0)
        {
          Console.WriteLine("!!! ERROR !!! Please enter a POSITIVE integer and try again.");
          return BreadOrderUI();
        } 
        else 
        {
          return breadQuant;
        }
      }
      catch (System.Exception)
      {
        Console.WriteLine("!!! ERROR !!! Please enter an integer and try again.");
        return BreadOrderUI();
      }
    }

    public static int PastryOrderUI()
    {
      // Handle user input errors for Pastry, repeat prompt until input is accepted
      Console.WriteLine("Enter the quantity of Pastries you would like to purchase:");
      string pastryQuantString = Console.ReadLine();
      try
      {
        int pastryQuant = Int32.Parse(pastryQuantString);
        if (pastryQuant < 0)
        {
          Console.WriteLine("!!! ERROR !!! Please enter a POSITIVE integer and try again.");
          return PastryOrderUI();
        } 
        else 
        {
          return pastryQuant;
        }
      }
      catch (System.Exception)
      {
        Console.WriteLine("!!! ERROR !!! Please enter an integer and try again.");
        return PastryOrderUI();
      }
    }
  }
}