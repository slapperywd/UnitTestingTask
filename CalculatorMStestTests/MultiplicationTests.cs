using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorMStestTests
{
    [TestClass]
    public class MultiplicationTests
    {
        Calculator calc;

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [DataTestMethod]
        [DataRow(9.0, 2.0)]
        [DataRow(200.0, 7.0)]
        public void MultiplyPositiveNumbers(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Multiply(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a * b));
        }

        [DataTestMethod]
        [DataRow(-9.0, 2.0)]
        [DataRow(-200.0, 7.0)]
        public void MultiplyNegativeNumbers(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Multiply(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a * b));
        }

        [DataTestMethod]
        [DataRow(0.0, 2.0)]
        [DataRow(200.0, 0.0)]
        public double MultiplyByZero(double a, double b)
        {
            return calc.Multiply(a, b);
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }
    }
}
