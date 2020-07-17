using PierresBakery.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;


namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteAscii("Pierre's Bakery");

      Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5, buy 2 get 1 free. Pastries are $2 or 3 for $5");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadResponse = Console.ReadLine();
      int breadQuantity = int.Parse(breadResponse);
      Bread newBreadOrder = new Bread(breadQuantity);
      int breadTotal = newBreadOrder.GetTotalBread(breadQuantity);
      Console.WriteLine("How many pastries would you like?");
      string pastryResponse = Console.ReadLine();
      int pastryQuantity = int.Parse(pastryResponse);
      Pastry newPastryOrder = new Pastry(pastryQuantity);
      int pastryTotal = newPastryOrder.GetTotalPastry(pastryQuantity);
      Console.WriteLine("Your total is: $" + (breadTotal + pastryTotal));
      Console.WriteLine("Is your order correct? Press [Y] for Yes, [N] for No");
      string completeOrder = Console.ReadLine();
      if (completeOrder == "y" || completeOrder == "Y")
      {
        Console.WriteLine("Thanks, have a nice day!");
        Main();
      }
      else
      {
        Console.WriteLine("Okay, which would you like to revise? Type [Bread Order] [Pastry Order] or [Nevermind] to go back to Start a New Order");
        string reviseOrder = Console.ReadLine();
        if (reviseOrder == "Bread Order" || reviseOrder == "bread order")
        {
          Console.WriteLine("No problem! How many loaves of bread would you like?");
          breadResponse = Console.ReadLine();
          breadQuantity = int.Parse(breadResponse);
          breadTotal = newBreadOrder.GetTotalBread(breadQuantity);
          Console.WriteLine("Would you also like to revise your pastry order? Press [Y] for Yes, [N] for No");
          string revisePastry = Console.ReadLine();
          if (revisePastry == "Y" || revisePastry == "y")
          {
            Console.WriteLine("No problem! How many pastries would you like?");
            pastryResponse = Console.ReadLine();
            pastryQuantity = int.Parse(pastryResponse);
            pastryTotal = newPastryOrder.GetTotalPastry(pastryQuantity);
            Console.WriteLine("Your new total is: $" + (breadTotal + pastryTotal));
            Main();
          }
          else
          {
            Console.WriteLine("Your new total is: $" + (breadTotal + pastryTotal));
            Main();
          }

        }
        else if (reviseOrder == "Pastry Order" || reviseOrder == "pastry order")
        {
          Console.WriteLine("No problem! How many pastries would you like?");
          pastryResponse = Console.ReadLine();
          pastryQuantity = int.Parse(pastryResponse);
          pastryTotal = newPastryOrder.GetTotalPastry(pastryQuantity);
          Console.WriteLine("Would you also like to revise your bread order? Press [Y] for Yes, [N] for No");
          string reviseBread = Console.ReadLine();
          if (reviseBread == "Y" || reviseBread == "y")
          {
            Console.WriteLine("No problem! How many loaves of bread would you like?");
            breadResponse = Console.ReadLine();
            breadQuantity = int.Parse(breadResponse);
            breadTotal = newBreadOrder.GetTotalBread(breadQuantity);
            Console.WriteLine("Your new total is: $" + (breadTotal + pastryTotal));
            Main();
          }
          else
          {
            Console.WriteLine("Your new total is: $" + (breadTotal + pastryTotal));
            Main();
          }
        }
        else
        {
          Main();
        }
      }
    }
  }
}