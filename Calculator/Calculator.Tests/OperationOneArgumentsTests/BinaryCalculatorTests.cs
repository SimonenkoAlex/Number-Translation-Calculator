using Calculator.OperationOneArguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class BinaryCalculatorTests
    {
        [TestMethod]
        public void BinaryCalculatorTest()
        {
            BinaryCalculator calculator = new BinaryCalculator();
            Assert.AreEqual("111", calculator.Calculate("7"));
        }
    }
}
