using System;
using NUnit.Framework;
using Calculator.OperationOneArguments;

namespace Calculator.Tests.OperationOneArguments
{
    [TestFixture]
    public class DecimalCalculatorTests
    {
        [Test]
        public void NegativeNumberTest()
        {
            DecimalCalculator calculator = new DecimalCalculator();
            Assert.AreEqual("-7", calculator.Calculate("11111111111111111111111111111001"));
        }

        [Test]
        public void PositiveNumberTest()
        {
            DecimalCalculator calculator = new DecimalCalculator();
            Assert.AreEqual("7", calculator.Calculate("111"));
        }

        [TestCase("7")]
        [TestCase("abcdefgh")]
        public void CalculateTest(string firstValue)
        {
            var calculator = new DecimalCalculator();
            Assert.Throws<FormatException>(() => calculator.Calculate(firstValue));
        }
    }
}
