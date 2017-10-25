using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorMStestTests
{
    [TestClass]
    public class DivisionTests
    {
        Calculator calc;

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
        }
     
        [DataTestMethod]
        [DataRow(9.0, 2.0)]
        [DataRow(1400.0, 7.0)]
        public void PositiveNumbersDivision(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Divide(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a / b));
        }

        [DataTestMethod]
        [DataRow(9.0, -2.0)]
        [DataRow(1400.0, -7.0)]
        public void NegativeNumbersDivision(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Divide(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a / b));
        }

        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<Exception>(() => calc.Divide(200.0, 0.0));
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }
    }
}
