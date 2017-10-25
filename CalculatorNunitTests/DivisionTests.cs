using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorNunitTests
{
    [TestFixture]
    class DivisionTests
    {
        Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [TestCase(9.0, 2.0, ExpectedResult = 4.5)]
        [TestCase(1400.0, 7.0, ExpectedResult = 200)]
        public double PositiveNumbersDivision(double a, double b)
        {
            return calc.Divide(a, b);
        }

        [TestCase(9.0, -2.0, ExpectedResult = -4.5)]
        [TestCase(1400.0, -7.0, ExpectedResult = -200)]
        public double NegativeNumbersDivision(double a, double b)
        {
            return calc.Divide(a, b);
        }

        [Test]
        public void DivideByZero()
        {
            Assert.Throws<Exception>(() => calc.Divide(200.0, 0.0));
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }
    }
}
