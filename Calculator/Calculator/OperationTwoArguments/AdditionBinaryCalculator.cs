using System;

namespace Calculator.OperationTwoArguments
{
    public class AdditionBinaryCalculator : ITwoArgumentsCalculator
    {
        public string Calculate(int firstArgument, int secondArgument)
        {
            return Convert.ToString(Convert.ToInt32(firstArgument + secondArgument), 2);
        }
    }
}
