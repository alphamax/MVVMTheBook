using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationForTests.ViewModel;

namespace Tests
{
    [TestClass]
    public class TestsVM
    {
        [TestMethod]
        public void IntegrationNormalSort()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 3000000;
            vm.Main.SortFlag = true;
            vm.Main.OrderByFlag = false;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
        }

        [TestMethod]
        public void IntegrationNormalOrder()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 3000000;
            vm.Main.SortFlag = false;
            vm.Main.OrderByFlag = true;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
        }


        [TestMethod]
        public void IntegrationLimite_0_Sort()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 0;
            vm.Main.SortFlag = true;
            vm.Main.OrderByFlag = false;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
            Assert.AreEqual(0, vm.Main.TableauResultat.Count);
        }

        [TestMethod]
        public void IntegrationLimite_0_Order()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 0;
            vm.Main.SortFlag = false;
            vm.Main.OrderByFlag = true;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
            Assert.AreEqual(0, vm.Main.TableauResultat.Count);
        }

        [TestMethod]
        public void IntegrationLimite_Negatif_Sort()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = -20;
            vm.Main.SortFlag = true;
            vm.Main.OrderByFlag = false;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
            Assert.AreEqual(0, vm.Main.TableauResultat.Count);
        }

        [TestMethod]
        public void IntegrationLimite_Negatif_Order()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = -10;
            vm.Main.SortFlag = false;
            vm.Main.OrderByFlag = true;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.TableauResultat != null);
            Assert.AreEqual(0, vm.Main.TableauResultat.Count);
        }
    }
}
