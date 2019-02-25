using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.OperationTwoArguments
{
    public class TwoArgumentsFactoryBinary
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Addition": return new AdditionBinaryCalculator();
                //case "Subtraction": return new SubtractionCalculator();
                //case "Multiplication": return new MultiplyCalculator();
                //case "Division": return new DivisionCalculator();
                //case "Powerxy": return new PowerxyCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
