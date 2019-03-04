using System;

namespace Calculator.OperationOneArguments
{
    public class NegationCalculator : IOneArgumentsCalculator
    {
        public string Calculate(string firstArgument)
        {
            // Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число
            int j = Convert.ToInt32(firstArgument);
            int numberSystem = 2;
            for (int i = 0; i < firstArgument.Length; i++)
                if ((firstArgument[i] != 1) || (firstArgument[i] != 0))
                    numberSystem = 10;
            // Преобразует целое число в эквивалентное строковое представление в 2-ичной С.С.                 
            return firstArgument = Convert.ToString((numberSystem == 10) ? ~j+1 : ~j, numberSystem);
        }
    }
}
