using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void Feladat_3Test()
        {
           List<Tehen> happyCows = new List<Tehen>();
           string aktualSzoveg = "Az állomány " + happyCows.Count + " tehén adatait tartalmazza.";

           Assert.AreEqual("Az állomány 0 tehén adatait tartalmazza.", aktualSzoveg);
        }

        [TestMethod()]
        public void Feladat_7TestHaLeszarmazott()
        {
            List<Tehen> happyCows = [new Tehen("BABI1")];
            string tehenId = "BA";
            var leszarmazottTehenek = happyCows.Where(cow => cow.Id.StartsWith(tehenId) && cow.Id != tehenId);

            Assert.AreEqual("A leszármazottak száma: 1", $"A leszármazottak száma: {leszarmazottTehenek.Count()}");
        }

        [TestMethod()]
        public void Feladat_7TestHaOnmaga()
        {
            List<Tehen> happyCows = [new Tehen("BA")];
            string tehenId = "BA";
            var leszarmazottTehenek = happyCows.Where(cow => cow.Id.StartsWith(tehenId) && cow.Id != tehenId);

            Assert.AreEqual("A leszármazottak száma: 0", $"A leszármazottak száma: {leszarmazottTehenek.Count()}");
        }
    }
}