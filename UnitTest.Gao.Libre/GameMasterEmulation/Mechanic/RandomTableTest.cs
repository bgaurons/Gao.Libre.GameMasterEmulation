using Gao.Libre.GameMasterEmulation.Common;
using Gao.Libre.GameMasterEmulation.Mechanic;
using Gao.Libre.GameMasterEmulation.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Gao.Libre.GameMasterEmulation.Mechanic
{
    [TestClass]
    public class RandomTableTest
    {
        [TestCleanup]
        public void FixStuff()
        {
            RandomNumberGeneration.NextFunction = null;
        }

        [TestMethod]
        public void EnumToDictionaryTest_LocationAndQualityType()
        {
            var dictionary = RandomTable.EnumToDictionary<LocationAndQualityType>();

            Assert.AreEqual(LocationAndQualityType.SquareMeetingHall, dictionary[1]);
            Assert.AreEqual(LocationAndQualityType.BrightWellLit, dictionary[43]);
            Assert.AreEqual(LocationAndQualityType.BrightWellLit, dictionary[143]);
        }
    }
}
