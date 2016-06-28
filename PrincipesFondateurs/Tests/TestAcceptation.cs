using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationForTests.ViewModel;

namespace Tests
{
    [TestClass]
    public class TestAcceptation
    {
        [TestMethod]
        public void AcceptanceNormalOrderQuick()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 3000000;
            vm.Main.SortFlag = false;
            vm.Main.OrderByFlag = true;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.MillisecondesEcoulees < 1000);
        }

        [TestMethod]
        public void AcceptanceNormalSortQuick()
        {
            ViewModelLocator vm = new ViewModelLocator();
            vm.Main.NbElement = 3000000;
            vm.Main.SortFlag = true;
            vm.Main.OrderByFlag = false;
            vm.Main.CalculCommand.Execute(null);
            Assert.IsTrue(vm.Main.MillisecondesEcoulees < 1000);
        }

        
    }
}
