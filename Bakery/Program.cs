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
      Bread orderBread = new Bread(breadQuant);
      Pastry orderPastry = new Pastry(pastryQuant);

      int breadTotal = orderBread.BreadCost();
      int pastryTotal = orderPastry.PastryCost();
      int grandTotal = breadTotal + pastryTotal;

      // Display output
      Console.WriteLine("***************************");
      Console.WriteLine("Bread Subtotal ----- $" + breadTotal);
      Console.WriteLine("Pastry Subtotal ---- $" + pastryTotal);
      Console.WriteLine("GRAND TOTAL -------- $" + grandTotal);
      Console.WriteLine("***************************");
      Console.WriteLine("Enter [y] to order again. Any other key to quit.");
      string response = Console.ReadLine();

      // UI Logic to run again or quit
      if (response.ToLower() == "y")
      {
        Main();
      }
      else 
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}
