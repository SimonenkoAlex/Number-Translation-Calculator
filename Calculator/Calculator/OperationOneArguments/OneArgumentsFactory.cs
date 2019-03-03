using System;

namespace Calculator.OperationOneArguments
{
    public static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btnBinary": return new BinaryCalculator();
                case "btnDecimal": return new DecimalCalculator();
                case "SignChange": return new NegationCalculator();
                default: throw new Exception("Неизвестная операция");
            }

        }
    }
}
