using Calculator.OperationOneArguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    [TestClass]
    public class DecimalCalculatorTests
    {
        [TestMethod]
        public void DecimalCalculatorTest()
        {
            DecimalCalculator calculator = new DecimalCalculator();
            Assert.AreEqual("7", calculator.Calculate("111"));
        }
    }
}
