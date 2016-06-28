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
    public class TestV1
    {
        [TestMethod]
        public void SimpleSubstitution()
        {
            RectangleV1 r = new RectangleV1() { Largeur = 10, Longueur = 20 };
            Assert.IsTrue(r.Longueur != r.Largeur);

            //Après substitution
            CarreV1 c = new CarreV1() { Largeur = 10, Longueur = 20 };
            Assert.IsTrue(c.Longueur != c.Largeur);
        }
    }
}
