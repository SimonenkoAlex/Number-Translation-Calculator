using System;

namespace Calculator.OperationTwoArguments
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(int systemName)
        {
            switch (systemName)
            {
                case 2: return new SignChangeBinary();
                case 10: return new SignChangeDecimal();
                default: throw new Exception("Неизвестная операция");
            }

        }
    }
}
