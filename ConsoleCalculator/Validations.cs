using System;
using System.Threading;

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
            if (!double.TryParse(Console.ReadLine(), out double operand))
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");
                Console.Write("Enter a number: ");
                Thread.Sleep(2500);
                operand = ValidateOperand();
                Console.Clear();
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

            if (@operator.Key != ConsoleKey.Add && @operator.Key != ConsoleKey.Subtract && @operator.Key != ConsoleKey.Divide && @operator.Key != ConsoleKey.Multiply)
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");
                Console.Write("Enter a mathematical Operator: ");
                Thread.Sleep(2500);
                @operator = ValidateOperator();
                Console.Clear();
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
            Console.WriteLine("Enter a non-zero divisor: ");
            Console.Write("Re-Enter number and press enter.\n\n");
            Console.Write($"{firstOperand}/");
            secondOperand = double.Parse(Console.ReadLine());
            Console.Clear();
            return secondOperand;
        }
    }
}