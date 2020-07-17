using PierresBakery.Models;
using System;
using System.Collections.Generic;


namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5, buy 2 get 1 free. Pastries are $2 or 3 for $5");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadResponse = Console.ReadLine();
      int breadQuantity = int.Parse(breadResponse);
      Bread newBreadOrder = new Bread(breadQuantity);
      Console.WriteLine("How many pastries would you like?");
      string pastryResponse = Console.ReadLine();
      int pastryQuantity = int.Parse(pastryResponse);
      Pastry newPastryOrder = new Pastry(pastryQuantity);
    }
  }
}