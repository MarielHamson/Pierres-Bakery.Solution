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
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int breadQuantity = 5;
      Bread newBreadOrder = new Bread(breadQuantity);
      int result = newBreadOrder.BreadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void GetTotalBread_GetTotalBreadWithDiscount_Int()
    {
      int breadQuantity = 5;
      Bread newBreadOrder = new Bread(breadQuantity);
      int total = newBreadOrder.GetTotalBread(breadQuantity);
      int result = 20;
      Assert.AreEqual(total, result);
    }
  }
}