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
    public class SpraveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sprave sprave = new Sprave();
            List<Sprava> popis_sprava = sprave.dohvati_sve_sprave();
            Assert.AreNotEqual(0, popis_sprava.Count, "Nije dohvaćena niti jedna sprava!");
        }
    }
}
