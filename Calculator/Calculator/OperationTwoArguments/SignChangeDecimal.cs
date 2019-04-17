namespace Calculator.OperationTwoArguments
{
    public class SignChangeDecimal : ITwoArgumentsCalculator
    {
        public int Calculate(int firstArgument, int numberSystem)
        {
                return ~firstArgument + 1;
        }
    }
}
