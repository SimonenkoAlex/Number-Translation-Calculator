using System;
using System.Windows.Forms;

namespace Calculator.OperationOneArguments
{
    public class DecimalCalculator : IOneArgumentsCalculator
    {
        public string Calculate(string firstArgument)
        {
            // Преобразует строковое представление числа в эквивалентное целое число
            int j = Convert.ToInt32(firstArgument, 2);
            // Преобразует целое число в эквивалентное строковое представление в 10-ичной С.С.                 
            return firstArgument = Convert.ToString(j, 10);
        }
    }
}
