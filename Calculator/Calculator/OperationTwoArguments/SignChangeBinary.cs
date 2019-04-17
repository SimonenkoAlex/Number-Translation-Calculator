using System;

namespace Calculator.OperationTwoArguments
{
    public class SignChangeBinary : ITwoArgumentsCalculator
    {
        public int Calculate(int firstArgument, int numberSystem)
        {
            int argumentDecimal = 0, baseValue = 1, rem;
            while (firstArgument > 0)
            {
                rem = firstArgument % 10;
                argumentDecimal += rem * baseValue;
                firstArgument /= 10;
                baseValue *= 2;
            }
            return argumentDecimal;
        }
    }
}
