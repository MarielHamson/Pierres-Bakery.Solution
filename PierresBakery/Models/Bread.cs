using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadQuantity { get; }

    public Bread(int breadQuantity)
    {
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