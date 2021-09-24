using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("***************************");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("***************************");
      Console.WriteLine("Prices:");
      Console.WriteLine("Bread: ---------------- $5");
      Console.WriteLine("Pastries -------------- $2");
      Console.WriteLine("***************************");
      Console.WriteLine("Current deals:");
      Console.WriteLine("Every 3rd Loaf of Bread is free");
      Console.WriteLine("Every 3rd Pastry is $1");
      Console.WriteLine("***************************");
      Console.WriteLine("Enter the quantity of Bread you would like to purchase:");
      int breadQuant = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Enter the quantity of Pastries you would like to purchase:");
      int pastryQuant = Int32.Parse(Console.ReadLine());

      Bread orderBread = new Bread();
      Pastry orderPastry = new Pastry();
      orderBread.BreadOrder = breadQuant;
      orderPastry.PastryOrder = pastryQuant;

      // int grandTotal = orderBread.BreadOrder + orderPastry.PastryOrder;
      Console.WriteLine("***************************");
      Console.WriteLine("Bread Subtotal ----- $" + orderBread.BreadOrder);
      Console.WriteLine("Pastry Subtotal ---- $" + orderPastry.PastryOrder);
      Console.WriteLine("Grand total -------- $" + (orderBread.BreadOrder + orderPastry.PastryOrder));
    }
  }
}