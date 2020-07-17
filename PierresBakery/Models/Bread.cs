using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; }

    public Bread(string bread, int price)
    {
      Price = price;
      myOrder.Add(this);
    }
    private static Dictionary<string, int> myOrder = new Dictionary<string, int>()
    {

    };

    public static Dictionary<string, int> TrackOrder()
    {
      return myOrder;
    }

  }
}