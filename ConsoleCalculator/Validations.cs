using System;
using System.Threading;
using Spectre.Console;

namespace ConsoleCalculator
{
    /// <summary>
    /// Check all user input.
    /// </summary>
    internal static class Validations
    {
        /// <summary>
        /// Ensure a valid numeral is entered.
        /// </summary>
        /// <returns>A valid numeral.</returns>
        public static double ValidateOperand()
        {
            double operand;
            while (!(double.TryParse(Console.ReadLine(), out operand)))
            {
                Console.Clear();
                AnsiConsole.Write(new Markup("[red]Wrong input![/]\n"));
                AnsiConsole.Write(new Markup("[red]Enter a valid number..[/]"));
                Thread.Sleep(2000);
                Console.Clear();
                AnsiConsole.Write(new Markup("[blue]Enter operand: [/]"));
            }
            return operand;
        }

        /// <summary>
        /// Ensure a valid basic mathematical operator is entered(+,/,*,-).
        /// </summary>
        /// <returns>A valid operator</returns>
        public static ConsoleKeyInfo ValidateOperator()
        {
            ConsoleKeyInfo @operator = Console.ReadKey();

            while (@operator.Key != ConsoleKey.Add && @operator.Key != ConsoleKey.Subtract && @operator.Key != ConsoleKey.Divide && @operator.Key != ConsoleKey.Multiply)
            {
                Console.Clear();
                AnsiConsole.Write(new Markup("[red]Wrong input![/]\n"));
                AnsiConsole.Write(new Markup("[red]Enter a valid mathematical Operator.[/]"));
                Thread.Sleep(2000);
                Console.Clear();
                AnsiConsole.Write(new Markup("[blue]Enter operator: [/]"));
                @operator = Console.ReadKey();
            }
            return @operator;
        }

        /// <summary>
        /// Ensure divisor is not zero.
        /// </summary>
        /// <param name="firstOperand"></param>
        /// <param name="secondOperand"></param>
        /// <returns></returns>
        public static double ValidateDivisor(double firstOperand, double secondOperand)
        {
            AnsiConsole.Write(new Markup("[red]Enter a non-zero divisor: [/]\n"));
            AnsiConsole.Write(new Markup("[red]Re-Enter number and press enter.\n\n[/]"));
            AnsiConsole.Write(new Markup($"[blue]{firstOperand }/[/]"));
            secondOperand = double.Parse(Console.ReadLine());
            Console.Clear();
            return secondOperand;
        }
    }
}