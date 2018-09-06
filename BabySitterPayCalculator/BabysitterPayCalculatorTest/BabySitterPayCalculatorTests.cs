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
            Calculator = new Babysitter(17, 4, 12, 8, 16);
        }

        [TestMethod]
        public void StartTimeToBedTimeOneHour()
        {
            Assert.AreEqual(12, Calculator.Calculate(17, 1, 21));
        }

        [TestMethod]
        public void StartTimeToBedTimeTwoHours()
        {
            Assert.AreEqual(24, Calculator.Calculate(17, 2, 21));
        }

        [TestMethod]
        public void StartTimeToBedTimeThreeHours()
        {
            Assert.AreEqual(36, Calculator.Calculate(17, 3, 21));
        }

        [TestMethod]
        public void StartTimeToPastBedTimeFiveHours()
        {
            Assert.AreEqual(56, Calculator.Calculate(17, 5, 21));
        }

        [TestMethod]
        public void StartTimeToPastMidnightEightHours()
        {
            Assert.AreEqual(88, Calculator.Calculate(17, 8, 21));
        }

        [TestMethod]
        public void StartTimeToPastMidnightTenHours()
        {
            Assert.AreEqual(120, Calculator.Calculate(17, 10, 21));
        }
    }
}
