using Microsoft.VisualStudio.TestTools.UnitTesting;
using tehenek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehenek.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void BeolvasasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Feladat3Test()
        {
            List<Tehen> happyCows = new List<Tehen>();
            string varhatoSzoveg = "Az állomány " + happyCows.Count + " tehén adatait tartalmazza.";

            Assert.AreEqual("Az állomány 0 tehén adatait tartalmazza.", varhatoSzoveg);
        }
    }
}