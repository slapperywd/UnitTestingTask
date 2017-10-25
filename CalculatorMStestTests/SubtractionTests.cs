using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;
namespace CalculatorMStestTests
{
    [TestClass]
    public class SubtractionTests
    {
        Calculator calc;

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
        }
  
        [DataTestMethod]
        [DataRow(9.0, 2.0)]
        [DataRow(200.0, 180.0)]
        public void PositiveNumbersSub(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Sub(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a - b));
        }

        [DataTestMethod]
        [DataRow(-9.0, 2.0)]
        [DataRow(-200.0, 180.0)]
        public void NegativeNumbersSub(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Sub(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a - b));
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }
    }
}
