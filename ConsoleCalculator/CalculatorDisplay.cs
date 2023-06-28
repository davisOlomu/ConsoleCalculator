using System;
using static ConsoleCalculator.Calculations;

namespace ConsoleCalculator
{
    public class CalculatorDisplay
    {
        public static void Main()
        {
            Console.Title = "Console Calculator";
            Console.SetWindowSize(45, 25);

            Console.Write("Enter first operand and press enter: ");
            double firstOperand = UserInputValidation.ValidateOperand();
            Console.Clear();

            Console.Write("Enter operator: ");
            ConsoleKeyInfo @operator = UserInputValidation.ValidateOperator();
            Console.Clear();

            Console.Write("Enter second operand and press enter: ");
            double secondOperand = UserInputValidation.ValidateOperand();

            DoCalculations(firstOperand, secondOperand, @operator);
            // Continue calculating using last result
            ReCalculation.ReCalculate();
        }
    }
}
