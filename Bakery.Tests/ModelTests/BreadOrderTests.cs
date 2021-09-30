using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_Initialize_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantityAndPrice_ReturnBreadQuantityAndBreadPrice_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(1, newBread.BreadQuantity);
      Assert.AreEqual(0, newBread.BreadPrice);
    }

    [TestMethod]
    public void SetQuantity_SetQuantity_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);

      int updatedQuantity = 2;
      newBread.BreadQuantity = updatedQuantity;
      int result = newBread.BreadQuantity;

      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      Bread newBread = new Bread(2);

      int updatedPrice = 2;
      newBread.BreadPrice = updatedPrice;
      int result = newBread.BreadPrice;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetPrice_Get1BreadCost_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.BreadCost());
    }

    [TestMethod]
    public void GetPrice_Get3BreadCost_Int()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.BreadCost());
    }

    [TestMethod]
    public void GetPrice_Get6BreadCost_Int()
    {
      Bread newBread = new Bread(6);
      Assert.AreEqual(20, newBread.BreadCost());
    }
  }
}
