using Gao.Libre.GameMasterEmulation.Common;
using Gao.Libre.GameMasterEmulation.Mechanic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTest.Gao.Libre.GameMasterEmulation.Mechanic
{
    [TestClass]
    public class DiceTest
    {
        [TestCleanup]
        public void FixStuff()
        {
            RandomNumberGeneration.NextFunction = null;
        }

        [TestMethod]
        public void RollTest_Nominal()
        {
            RandomNumberGeneration.NextFunction = (a, b) => 2;
            //The random number will be 2, but this is selecting from an array that goes from 0-5; 2 is 3.
            //3*3 = 9.
            Assert.AreEqual(9, Dice.Roll(3, 6).Sum());
        }
    }
}
