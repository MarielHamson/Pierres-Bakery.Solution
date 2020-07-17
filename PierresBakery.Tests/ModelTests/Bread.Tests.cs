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
      Bread newBreadOrder = new Bread(5, 5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int quantity = 5;
      int price = 5;
      Bread newBreadOrder = new Bread(price, quantity);
      int result = newBreadOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int price = 5;
      int quantity = 5;
      Bread newBreadOrder = new Bread(price, quantity);
      int result = newBreadOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SumBreadOrder_ReturnsTotalBreadOrder_Int()
    {
      int price = 5;
      int quantity = 5;
      Bread newBreadOrder = new Bread(price, quantity);
      int total = newBreadOrder.GetTotal();
      int result = newBreadOrder.Quantity * newBreadOrder.Price;
      Assert.AreEqual(total, result);
    }
  }
}