using System;
using static ConsoleCalculator.Calculations;

namespace ConsoleCalculator
{
    /// <summary>
    /// UserInterface.
    /// </summary>
    public class Display
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

            DoCalculations(firstOperand, secondOperand, @operator);

            ReCalculation.ReCalculate();
        }
    }
}
