using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuildUp_teretana;
namespace JedinicnoTestiranje
{
    [TestClass]
    public class ČlanoviTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FrmČlanovi forma = new FrmČlanovi();
            List<Clan> clanovi = forma.dohvati_clanove();
            int ukupno = clanovi.Count;
            Assert.AreNotEqual(0, ukupno, "Nije dobra metoda za dohvat članova!");

        }
    }
}
