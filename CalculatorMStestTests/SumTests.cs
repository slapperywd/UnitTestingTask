using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;
using System;

namespace CalculatorMStestTests
{
    [TestClass]
    public class SumTests
    {
        private Calculator calc;
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
        }
       
        [DataTestMethod]
        [DataRow(1.0, 2.0)]
        [DataRow(201.0, 199.0)]
        public void PositiveNumbersSum(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a + b));
        }
     
        [DataTestMethod]
        [DataRow(-11.0, 2.0)]
        [DataRow(-201.0, 199.0)]
        public void NegativeNumbersSum(double a, double b)
        {
            //arrange
            //already configured in SetUp() method

            //act
            double actual = calc.Add(a, b);

            //assert
            Assert.AreEqual(actual, (double)(a + b));
        }

        //doesn't work
       /* [DeploymentItem(@"D:\NETprojects\CalculatorUnitTestsTask\CalculatorMStestTests\TestData\negative.xml"),
       DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
       "|DataDirectory|\\negative.xml", "negative.xml",
        DataAccessMethod.Sequential), TestMethod]
        public void NegativeNumbersSumViaXML()
        {
           // arrange

              double a = Double.Parse(TestContext.DataRow["A1"].ToString());
            double b = Double.Parse(TestContext.DataRow["A2"].ToString());
            double result = calc.Add(a, b);
            Assert.AreEqual(result, a + b);
            //act

          }*/

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }
    }
}
