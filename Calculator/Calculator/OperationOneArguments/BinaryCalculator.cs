using System;

namespace Calculator.OperationOneArguments
{
    public class BinaryCalculator: IOneArgumentsCalculator
    {
        public string Calculate(string firstArgument)
        {
            // Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число
            int j = Convert.ToInt32(firstArgument);
            // Преобразует целое число в эквивалентное строковое представление в 2-ичной С.С.                 
            return firstArgument = Convert.ToString(j, 2); ;
        }
    }
}
