using NUnit.Framework;
using Calculator.OperationOneArguments;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    [TestFixture]
    class BinaryCalculatorTests
    {
        [Test]
        public void BinaryCalculatorTest()
        {
            BinaryCalculator calculator = new BinaryCalculator();
            Assert.AreEqual(111, calculator.Calculate("7"));
        }
    }
}
