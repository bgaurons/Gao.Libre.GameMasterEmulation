using Gao.Libre.GameMasterEmulation.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Gao.Libre
{
    [TestClass]
    public class RandomNumberGenerationTest
    {
        [TestCleanup]
        public void FixStuff()
        {
            RandomNumberGeneration.NextFunction = null;
        }

        [TestMethod]
        public void NextFunctionTest_Smoke()
        {
            RandomNumberGeneration.NextFunction = null;
            //Show that when this is set to null we get the default function.
            Assert.AreEqual(1, RandomNumberGeneration.NextFunction(1, 2), "Default doesn't work.");

            RandomNumberGeneration.NextFunction = (min, max) => 5;
            Assert.AreEqual(5, RandomNumberGeneration.NextFunction(100, -50), "DI doesn't work");
        }
    }
}
