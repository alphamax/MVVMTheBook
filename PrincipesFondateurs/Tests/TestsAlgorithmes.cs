using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationForTests.Algorithme;
using Moq;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestsAlgorithmes
    {
        [TestMethod]
        public void UnitaireNormalSort()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int taille = 3000000;
            var array = new List<double>();
            for (int i = 0; i < taille; i++)
            {
                array.Add(r.NextDouble());
            }

            OrderSystem.ReorderArray(ref array, false, true);

            for (int i = 1; i < array.Count; i++)
            {
                Assert.IsTrue(array[i - 1] <= array[i]);
            }
        }

        [TestMethod]
        public void UnitaireNormalOrder()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int taille = 3000000;
            var array = new List<double>();
            for (int i = 0; i < taille; i++)
            {
                array.Add(r.NextDouble());
            }

            OrderSystem.ReorderArray(ref array, true, false);

            for (int i = 1; i < array.Count; i++)
            {
                Assert.IsTrue(array[i - 1] <= array[i]);
            }
        }

        [TestMethod]
        public void UnitaireNormalCompteGeneration()
        {
            int taille = 3000000;
            Random r = new Random(DateTime.Now.Millisecond);

            var mock = new Mock<AbstractRandomEngine>();
            mock.Setup(c => c.GenerateNextDouble())
                .Returns(() => r.NextDouble());

            var array = mock.Object.GenerateArray(taille);

            Assert.AreEqual(taille, array.Count);
        }

        [TestMethod]
        public void UnitaireNormalRepartitionGeneration()
        {
            int taille = 3000000;
            int NbMaxParGroupe = 10;
            Random r = new Random(DateTime.Now.Millisecond);

            var mock = new Mock<AbstractRandomEngine>();
            mock.Setup(c => c.GenerateNextDouble())
                .Returns(() => r.NextDouble());

            var array = mock.Object.GenerateArray(taille);

            foreach (var groupe in array.GroupBy(c => c))
            {
                Assert.IsTrue(groupe.Count() < NbMaxParGroupe);
            }
        }
    }
}
