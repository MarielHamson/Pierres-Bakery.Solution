using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; }
    public int Quantity { get; }

    public Pastry(int price, int quantity)
    {
      Price = price;
      Quantity = quantity;
    }
    public int GetTotalPastry()
    {
      int Total = Price * Quantity;
      int TotalQuantityFree = Quantity / 3;
      int TotalPastryCost = (Total - TotalQuantityFree) * Price;
      return TotalPastryCost;
    }
  }
}