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




  }
}