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
    public class DodajClanarinuTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DodajClanarinu dodaj = new DodajClanarinu("test");
            string test = dodaj.BrojIskaznice;
            Assert.AreEqual("test", test, "Nije uspješno proslijeđen broj iskaznice u dodaj članarinu!");

        }
    }
}
