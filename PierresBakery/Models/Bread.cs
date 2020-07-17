using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    // public int Price { get; }
    public int BreadQuantity { get; }

    public Bread(int breadQuantity)
    {
      // Price = price;
      BreadQuantity = breadQuantity;
    }

    public int GetTotalBread(int breadQuantity)
    {
      int TotalBreadCost = 0;
      for (int i = 1; i <= breadQuantity; i++)
      {
        if (i % 3 == 0)
        {
          TotalBreadCost += 0;
        }
        else
        {
          TotalBreadCost += 5;
        }
      }
      return TotalBreadCost;
    }
  }
}