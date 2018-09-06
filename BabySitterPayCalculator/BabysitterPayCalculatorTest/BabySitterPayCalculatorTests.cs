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
            Calculator = new Babysitter(12, 8, 16);
        }

        [TestMethod]
        public void StartTimeToBedTimeOneHour()
        {
            Assert.AreEqual(12, Calculator.Calculate(5, 1, 9));
        }

        [TestMethod]
        public void StartTimeToBedTimeTwoHours()
        {
            Assert.AreEqual(24, Calculator.Calculate(5, 2, 9));
        }

        [TestMethod]
        public void StartTimeToBedTimeThreeHours()
        {
            Assert.AreEqual(36, Calculator.Calculate(5, 3, 9));
        }

        [TestMethod]
        public void StartTimeToPastBedTimeFiveHours()
        {
            Assert.AreEqual(56, Calculator.Calculate(5, 5, 9));
        }

        [TestMethod]
        public void StartTimeToPastMidnightEightHours()
        {
            Assert.AreEqual(88, Calculator.Calculate(5, 8, 9));
        }

        [TestMethod]
        public void StartTimeToPastMidnightTenHours()
        {
            Assert.AreEqual(120, Calculator.Calculate(5, 10, 9));
        }

        [TestMethod]
        public void StartTimeToPastMidnightTenHours7PMBedtime()
        {
            Assert.AreEqual(100, Calculator.Calculate(6, 9, 7));
        }

        [TestMethod]
        public void StartAfterBedTimeEndBeforeMidnight()
        {
            Assert.AreEqual(40, Calculator.Calculate(7, 5, 7));
        }

        [TestMethod]
        public void StartAfterBedTimeEndAfterMidnight()
        {
            Assert.AreEqual(56, Calculator.Calculate(7, 6, 7));
        }

        [TestMethod]
        public void StartAfterMidnight()
        {
            Assert.AreEqual(32, Calculator.Calculate(12, 2, 7));
        }
    }
}
