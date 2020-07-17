using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry(pastryQuantity);
      int result = newPastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }

    [TestMethod]
    public void GetTotalPastry_GetTotalPastryWithDiscount_Int()
    {
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry(pastryQuantity);
      int total = newPastryOrder.GetTotalPastry(pastryQuantity);
      int result = 9;
      Assert.AreEqual(total, result);
    }
  }
}