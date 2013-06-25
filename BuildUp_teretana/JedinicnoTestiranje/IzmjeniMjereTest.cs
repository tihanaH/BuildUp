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
    public class IzmjeniMjereTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IzmijeniMjere izmijeni = new IzmijeniMjere(3);
            Assert.AreEqual(3,izmijeni.BrojIskaznce, "Krivo proslijeđen broj iskaznice!");

        }
    }
}
