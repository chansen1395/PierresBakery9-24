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
      orderBread.BreadQuantity = 1;
      Assert.AreEqual(5, orderBread.BreadQuantity);
    }

    [TestMethod]
    public void Bread_PriceCalc_10()
    {
      Bread orderBread = new Bread();
      orderBread.BreadQuantity = 3;
      Assert.AreEqual(10, orderBread.BreadQuantity);
    }

    [TestMethod]
    public void Bread_PriceCalc_15()
    {
      Bread orderBread = new Bread();
      orderBread.BreadQuantity = 4;
      Assert.AreEqual(15, orderBread.BreadQuantity);
    }

  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CheckPrice_1()
    {
      Pastry orderPastry = new Pastry();
      orderPastry.PastryPrice = 1;
      Assert.AreEqual(1, orderPastry.PastryPrice);
    }

  }

  // [TestClass]
  // public class PastryTests
  // {
  //   [TestMethod]
  //   public void CheckWinner_CheckDraw_Draw()
  //   {
  //     Assert.AreEqual("Draw", Game.CheckWinner("rock", "rock"));
  //   }

  // }
}
