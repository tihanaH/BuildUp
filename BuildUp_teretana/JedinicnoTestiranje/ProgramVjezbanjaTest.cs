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
    public class ProgramVjezbanjaTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            frmProgramVjezbanja forma = new frmProgramVjezbanja(1);
            int test = forma.BrojIskaznice;
            Assert.IsTrue(test ==1,"Nije uspješno proslijeđen parametar!");

        }
    }
}
