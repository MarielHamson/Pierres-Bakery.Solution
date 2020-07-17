using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // public int Price { get; }
    public int PastryQuantity { get; }

    public Pastry(int pastryQuantity)
    {
      // Price = price;
      PastryQuantity = pastryQuantity;
    }

    public int GetTotalPastry(int PastryQuantity)
    {
      int TotalPastryCost = 0;
      for (int i = 0; i > PastryQuantity; i++)
      {
        if (i % 3 == 0)
        {
          TotalPastryCost += 0;
        }
        else
        {
          TotalPastryCost += 5;
        }
      }
      return TotalPastryCost;
    }
  }
}