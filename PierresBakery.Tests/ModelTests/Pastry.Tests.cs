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
      Pastry newPastryOrder = new Pastry(5, 5);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int quantity = 5;
      int price = 5;
      Pastry newPastryOrder = new Pastry(price, quantity);
      int result = newPastryOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int price = 5;
      int quantity = 5;
      Pastry newPastryOrder = new Pastry(price, quantity);
      int result = newPastryOrder.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SumPastryOrder_ReturnsTotalPastryOrder_Int()
    {
      int price = 5;
      int quantity = 5;
      Pastry newPastryOrder = new Pastry(price, quantity);
      int total = newPastryOrder.GetTotalPastry();
      int result = newPastryOrder.Quantity * newPastryOrder.Price;
      Assert.AreEqual(total, result);
    }

    [TestMethod]
    public void GetTotalPastry_GetTotalPastryWithDiscount_Int()
    {
      int price = 5;
      int quantity = 5;
      Pastry newPastryOrder = new Pastry(price, quantity);
      int total = newPastryOrder.GetTotalPastry();
      int result = (price * quantity) - (quantity / 3) * price;
      Assert.AreEqual(total, result);
    }
  }
}