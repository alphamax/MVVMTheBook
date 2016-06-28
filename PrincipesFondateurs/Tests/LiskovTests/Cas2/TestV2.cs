using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Liskov.Cas1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.LiskovTests.Cas1
{
    [TestClass]
    public class TestV2
    {
        [TestMethod]
        public void SimpleSubstitution()
        {
            CarreV2 c = new CarreV2() { LongueurCote = 10};
            Assert.AreNotEqual(0, c.Aire);
            Assert.AreNotEqual(0, c.Perimetre);

            //Après substitution
            RectangleV2 r = new RectangleV2() { LongueurCote = 10 };
            Assert.AreNotEqual(0, r.Aire);
            Assert.AreNotEqual(0, r.Perimetre);
        }
    }
}
