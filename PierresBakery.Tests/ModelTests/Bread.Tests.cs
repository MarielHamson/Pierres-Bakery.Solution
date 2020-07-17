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
      Bread newBreadOrder = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Bread newBreadOrder = new Bread(price);
      int result = newBreadOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void TrackOrder_ReturnsEmptyDictionary_Entries()
    {
      Dictionary<string, int> myOrder = new Dictionary<string, int>() { };
      Dictionary<string, int> result = Bread.TrackOrder();
      CollectionAssert.AreEqual(myOrder, result);
    }
    [TestMethod]
    public void TrackOrder_ReturnsAmtOfBread_myOrder()
    {
      string type = "bread";
      int amount = 1;
      Bread newBreadOrder = new Bread(type, amount);
      Dictionary<string, int> myOrder = new Dictionary<string, int>() { type, amount };
      Dictionary<string, int> result = myOrder.TrackOrder();
      CollectionAssert.AreEqual(myOrder, result);
    }
  }
}