using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNunitTests
{
    [TestFixture]
    class MultiplicationTests
    {
        Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [TestCase(9.0, 2.0, ExpectedResult = 18.0)]
        [TestCase(200.0, 7.0, ExpectedResult = 1400.0)]
        public double MultiplyPositiveNumbers(double a, double b)
        {
            return calc.Multiply(a, b);
        }

        [TestCase(-9.0, 2.0, ExpectedResult = -18.0)]
        [TestCase(-200.0, 7.0, ExpectedResult = -1400.0)]
        public double MultiplyNegativeNumbers(double a, double b)
        {
            return calc.Multiply(a, b);
        }

        [TestCase(0.0, 2.0, ExpectedResult = 0.0)]
        [TestCase(-9.0, 0.0, ExpectedResult = 0.0)]
        public double MultiplyByZero(double a, double b)
        {
            return calc.Multiply(a, b);
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }
    }
}
