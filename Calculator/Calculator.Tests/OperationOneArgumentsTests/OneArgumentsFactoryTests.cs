using System;
using NUnit.Framework;
using Calculator.OperationOneArguments;

namespace Calculator.Tests.OperationOneArgumentsTests
{
    public class OneArgumentsFactoryTests
    {
        [TestCase("btnBinary", typeof(BinaryCalculator))]
        [TestCase("btnDecimal", typeof(DecimalCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
