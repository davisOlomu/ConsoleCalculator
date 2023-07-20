using System;
using static ConsoleCalculator.Calculations;

namespace ConsoleCalculator
{
    /// <summary>
    /// App Entry Point.
    /// </summary>
    public class CalculatorDisplay
    {
        public static void Main()
        {
            Console.Title = "Console Calculator";
            Console.SetWindowSize(45, 25);

            Console.Write("Enter first operand and press enter: ");
            double firstOperand = Validations.ValidateOperand();
            Console.Clear();

            Console.Write("Enter operator: ");
            ConsoleKeyInfo @operator = Validations.ValidateOperator();
            Console.Clear();

            Console.Write("Enter second operand and press enter: ");
            double secondOperand = Validations.ValidateOperand();
            Console.Clear();

            DoCalculations(firstOperand, secondOperand, @operator);
            ReCalculate();
        }      
    }
}
