using NUnit.Framework;
using CSharpCalculator;

namespace CalculatorNunitTests
{
    [TestFixture]
    public class SumTests
    {
        Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [TestCase(1.0, 2.0, ExpectedResult = 3.0)]
        [TestCase("6.0", "7.0", ExpectedResult = 13.0)]
        [TestCase(201.0, 199.0, ExpectedResult = 400.0)]
        public double PositiveNumbersSum(double a, double b)
        {
            return calc.Add(a, b);
        }

        [TestCase(-4.0, 2.0, ExpectedResult = -2.0)]
        [TestCase(-50, 25.0, ExpectedResult = -25.0)]
        public double NegativeNumbersSum(double a, double b)
        {
            return calc.Add(a, b);
        }

        [TearDown]
        public void TearDown()
        {
            calc = null;
        }
    }
}
