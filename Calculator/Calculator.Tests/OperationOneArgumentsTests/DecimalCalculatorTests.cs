using NUnit.Framework;
using Calculator.OperationOneArguments;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    [TestFixture]
    class DecimalCalculatorTests
    {
        [Test]
        public void DecimalCalculatorTest()
        {
            DecimalCalculator calculator = new DecimalCalculator();
            Assert.AreEqual(7, calculator.Calculate("111"));
        }
    }
}
