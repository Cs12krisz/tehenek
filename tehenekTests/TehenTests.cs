using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TehenTests
    {


        [TestMethod()]
        public void hetiAtlagTestSzamitas()
        {
            Tehen tehenke = new Tehen("24");
            tehenke.EredmenytRogzit("0", "10");
            tehenke.EredmenytRogzit("3", "20");
            tehenke.EredmenytRogzit("5", "20");

            Assert.AreEqual(16, tehenke.hetiAtlag());

        }

        [TestMethod()]
        public void hetiAtlagTestHaromnalKevesebbNap()
        {
            Tehen tehenke = new Tehen("24");
            tehenke.EredmenytRogzit("0", "10");
            tehenke.EredmenytRogzit("3", "20");

            Assert.AreEqual(-1, tehenke.hetiAtlag());

        }


        [TestMethod()]
        public void EredmenytRogzitTest()
        {
            Tehen tehen = new Tehen("1");
            Tehen tehen2 = new Tehen("2");
            tehen.Mennyisegek[int.Parse("3")] = int.Parse("20");
            tehen2.EredmenytRogzit("3", "20");

            Assert.AreEqual(tehen.Mennyisegek[int.Parse("3")], tehen2.Mennyisegek[int.Parse("3")]);
        }

        [TestMethod()]
        public void EqualsTestHaAMasikNull()
        {
            Tehen tehen = new Tehen("1");
            Tehen? masik = null;

            Assert.IsFalse(tehen.Equals(masik));
        }

        [TestMethod()]
        public void EqualsTestHaAMasikIdNemEgyezik()
        {
            Tehen tehen = new Tehen("1");
            Tehen? masik = new Tehen("2");

            Assert.IsFalse(tehen.Equals(masik));
        }
    }
}