using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    // [TestMethod]
    // public void Bread_CheckPrice_1()
    // {
    //   Bread orderBread = new Bread();
    //   orderBread.BreadPrice = 1;
    //   Assert.AreEqual(1, orderBread.BreadPrice);
    // }

    [TestMethod]
    public void Bread_PriceCalc_5()
    {
      Bread orderBread = new Bread();
      orderBread.BreadOrder = 1;
      Assert.AreEqual(5, orderBread.BreadOrder);
    }

    [TestMethod]
    public void Bread_PriceCalc_10()
    {
      Bread orderBread = new Bread();
      orderBread.BreadOrder = 3;
      Assert.AreEqual(10, orderBread.BreadOrder);
    }

    [TestMethod]
    public void Bread_PriceCalc_15()
    {
      Bread orderBread = new Bread();
      orderBread.BreadOrder = 4;
      Assert.AreEqual(15, orderBread.BreadOrder);
    }

  }

  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void Pastry_PriceCalc_2()
    {
      Pastry orderPastry = new Pastry();
      orderPastry.PastryOrder = 1;
      Assert.AreEqual(2, orderPastry.PastryOrder);
    }

    [TestMethod]
    public void Pastry_PriceCalc_5()
    {
      Pastry orderPastry = new Pastry();
      orderPastry.PastryOrder = 3;
      Assert.AreEqual(5, orderPastry.PastryOrder);
    }

    [TestMethod]
    public void Pastry_PriceCalc_10()
    {
      Pastry orderPastry = new Pastry();
      orderPastry.PastryOrder = 6;
      Assert.AreEqual(10, orderPastry.PastryOrder);
    }
  }
}
