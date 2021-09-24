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
    public void Bread_CheckPrice_1()
    {
      Bread orderBread = new Bread();
      orderBread.BreadPrice = 1;
      Assert.AreEqual(1, orderBread.BreadPrice);
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
