using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_Initialize_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQuantityAndPrice_ReturnPastryQuantityAndPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(1, newPastry.PastryQuantity);
      Assert.AreEqual(0, newPastry.PastryPrice);
    }

    [TestMethod]
    public void SetQuantity_SetQuantity_Int()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);

      int updatedQuantity = 2;
      newPastry.PastryQuantity = updatedQuantity;
      int result = newPastry.PastryQuantity;

      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      Pastry newPastry = new Pastry(2);

      int updatedPrice = 2;
      newPastry.PastryPrice = updatedPrice;
      int result = newPastry.PastryPrice;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetPrice_Get1PastryCost_Int()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.PastryCost());
    }

    [TestMethod]
    public void GetPrice_Get3PastryCost_Int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(5, newPastry.PastryCost());
    }

    [TestMethod]
    public void GetPrice_Get6PastryCost_Int()
    {
      Pastry newPastry = new Pastry(6);
      Assert.AreEqual(10, newPastry.PastryCost());
    }
  }
}