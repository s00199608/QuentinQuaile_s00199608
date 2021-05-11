using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuentinQuaile_s00199608;

namespace DescreaseTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Game newGame = new Game();
            decimal expectedResult = 70m;

            newGame.DecreasePrice(30.99m);

            Assert.AreEqual(expectedResult, newGame.Price);

        }
    }
}
