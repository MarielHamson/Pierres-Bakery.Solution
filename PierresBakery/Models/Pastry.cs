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
  }
}