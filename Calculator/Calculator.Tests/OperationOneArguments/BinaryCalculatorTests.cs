using System;
using NUnit.Framework;
using Calculator.OperationOneArguments;

namespace Calculator.Tests.OperationOneArguments
{
    [TestFixture]
    public class BinaryCalculatorTests
    {
        [Test]
        public void NegativeNumberTest()
        {
            BinaryCalculator calculator = new BinaryCalculator();
            Assert.AreEqual("11111111111111111111111111111001", calculator.Calculate("-7"));
        }

        [Test]
        public void PositiveNumberTest()
        {
            BinaryCalculator calculator = new BinaryCalculator();
            Assert.AreEqual("111", calculator.Calculate("7"));
        }

        [TestCase("abcdefgh")]
        public void ExceptionTest(string firstValue)
        {
            var calculator = new BinaryCalculator();
            Assert.Throws<FormatException>(() => calculator.Calculate(firstValue));
        }
    }
}
