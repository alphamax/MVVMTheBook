using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestsDeBase
    {
        [TestMethod]
        public void TestPuissance()
        {
            //Phase Initialisation - Arrange
            double a = 2;
            double b = 3;
            // Phase Execution - Act
            double r = Math.Pow(a, b);
            //Phase Vérification - Assert
            Assert.AreEqual(8, r);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionParZero()
        {
            //Phase Initialisation - Arrange
            int a = 2;
            int b = 0;
            // Phase Execution - Act
            int r = a / b;
            //Phase Vérification - Assert
            Assert.AreEqual(1, r);
        }
    }
}
