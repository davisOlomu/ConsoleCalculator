using System;
using static ConsoleCalculator.Calculations;
using Spectre.Console;

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

            AnsiConsole.Write(new Markup("[blue]Enter first operand and press enter: [/]"));
            double firstOperand = Validations.ValidateOperand();
            Console.Clear();

            AnsiConsole.Write(new Markup("[blue]Enter operator: [/]"));
            ConsoleKeyInfo @operator = Validations.ValidateOperator();
            Console.Clear();

            AnsiConsole.Write(new Markup("[blue]Enter second operand and press enter: [/]"));
            double secondOperand = Validations.ValidateOperand();
            Console.Clear();

            DoCalculations(firstOperand, secondOperand, @operator);
            ReCalculate();
        }              
    }
}
