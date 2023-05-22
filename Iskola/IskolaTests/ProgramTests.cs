using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iskola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AzonositoTest()
        {
            Tanulok t = new Tanulok("2006;c;Bodnar Szilvia");
            Assert.AreEqual("6cbodszi",Program.Azonosito(t));
        }

        [TestMethod()]
        public void AzonositoTestHibas()
        {
            Tanulok t = new Tanulok("2006;c;Bodnar Szilvia");
            Assert.AreEqual("6abodszi", Program.Azonosito(t));
        }
    }
}