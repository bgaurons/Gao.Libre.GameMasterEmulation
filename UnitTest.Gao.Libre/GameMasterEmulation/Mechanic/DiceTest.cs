using Gao.Libre.GameMasterEmulation.Mechanic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Gao.Libre
{
    [TestClass]
    public class DiceTest
    {
        [TestCleanup]
        public void FixStuff()
        {
            Dice.NextFunction = null;
        }

        [TestMethod]
        public void NextFunctionTest_Smoke()
        {
            Dice.NextFunction = null;
            //Show that when this is set to null we get the default function.
            Assert.AreEqual(1, Dice.NextFunction(1, 2), "Default doesn't work.");

            Dice.NextFunction = (min, max) => 5;
            Assert.AreEqual(5, Dice.NextFunction(100, -50), "DI doesn't work");
        }
    }
}
