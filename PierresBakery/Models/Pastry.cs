using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryQuantity { get; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }

    public int GetTotalPastry(int pastryQuantity)
    {
      int TotalPastryCost = 0;
      for (int i = 1; i <= pastryQuantity; i++)
      {
        if (i % 3 == 0)
        {
          TotalPastryCost += 1;
        }
        else
        {
          TotalPastryCost += 2;
        }
      }
      return TotalPastryCost;
    }
  }
}