using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabysitterPayCalculator;

namespace BabysitterPayCalculatorTest
{
    [TestClass]
    public class BabysitterPayCalculatorTests
    {
        private Babysitter Calculator;
        
        [TestInitialize]
        public void InitTests()
        {
            Calculator = new Babysitter();
        }

        [TestMethod]
        public void TestTheTestPass()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestTheTestFail()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TestInit()
        {
            Assert.IsTrue(Calculator.GetType().Equals(typeof(Babysitter)));
        }
    }
}
