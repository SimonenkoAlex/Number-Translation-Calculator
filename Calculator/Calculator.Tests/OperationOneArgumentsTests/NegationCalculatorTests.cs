using Calculator.OperationOneArguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    [TestClass]
    public class NegationCalculatorTests
    {
        [TestMethod]
        public void NegationCalculatorTest()
        {
            NegationCalculator calculator = new NegationCalculator();
            Assert.AreEqual("-5", calculator.Calculate("5"));
        }
    }
}
