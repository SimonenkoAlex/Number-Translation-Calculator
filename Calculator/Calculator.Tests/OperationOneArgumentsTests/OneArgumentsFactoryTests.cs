using Calculator.OperationOneArguments;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    [TestClass]
    public class OneArgumentsFactoryTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            var calculatorBinary = OneArgumentsFactory.CreateCalculator("btnBinary");
            Assert.IsInstanceOfType(calculatorBinary, typeof(BinaryCalculator));
            var calculatorDecimal = OneArgumentsFactory.CreateCalculator("btnDecimal");
            Assert.IsInstanceOfType(calculatorDecimal, typeof(DecimalCalculator));
            var calculatorNegation = OneArgumentsFactory.CreateCalculator("SignChange");
            Assert.IsInstanceOfType(calculatorNegation, typeof(NegationCalculator));
        }
    }
}
