using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorNunitTests
{
    [TestFixture]
    class SubtractionTests
    {
        Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [TestCase(9.0, 2.0, ExpectedResult = 7.0)]
        [TestCase(200.0, 180.0, ExpectedResult = 20.0)]
        public double PositiveNumbersSub(double a, double b)
        {
            return calc.Sub(a, b);
        }

        [TestCase(-9.0, 2.0, ExpectedResult = -11.0)]
        [TestCase(-200.0, 199.0, ExpectedResult = -399.0)]
        public double NegativeNumbersSub(double a, double b)
        {
            return calc.Sub(a, b);
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }
    }
}
