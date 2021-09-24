using System;
using System.Collections.Generic;
using Bakery.Models;
using UI.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {                      
      // Display Menu
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

      // Handle user input, errors
      int breadQuant = OrdersUI.BreadOrderUI();
      int pastryQuant = OrdersUI.PastryOrderUI();

      // Determine order price
      Bread orderBread = new Bread();
      Pastry orderPastry = new Pastry();
      orderBread.BreadOrder = breadQuant;
      orderPastry.PastryOrder = pastryQuant;

      // Display output
      Console.WriteLine("***************************");
      Console.WriteLine("Bread Subtotal ----- $" + orderBread.BreadOrder);
      Console.WriteLine("Pastry Subtotal ---- $" + orderPastry.PastryOrder);
      Console.WriteLine("GRAND TOTAL -------- $" + (orderBread.BreadOrder + orderPastry.PastryOrder));
    }
  }
}