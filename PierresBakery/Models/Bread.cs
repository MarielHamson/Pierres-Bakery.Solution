using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; }
    public int Quantity { get; }

    public Bread(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }

    public int GetTotalBread()
    {
      int Total = Price * Quantity;
      int TotalQuantityFree = Quantity / 3;
      int TotalBreadCost = (Total - TotalQuantityFree) * Price;
      return TotalBreadCost;
    }
  }
}