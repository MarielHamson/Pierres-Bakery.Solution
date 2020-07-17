using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread(price);
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void TrackOrder_ReturnsEmptyDictionary_Entries()
    {
      Dictionary<string, int> myOrder = new Dictionary<string, int>() { };
      Dictionary<string, int> result = Bread.TrackOrder();
      CollectionAssert.AreEqual(newDict, result);
    }
  }
}