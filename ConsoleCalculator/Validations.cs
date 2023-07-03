using System;
using System.Threading;

namespace ConsoleCalculator
{
    /// <summary>
    /// Ensures all inputs during calculation are in the correct format.
    /// </summary>
    internal static class Validations
    {

       /// <summary>
       /// Ensures user input is a valid number.
       /// </summary>
       /// <param name="operand">represents user input</param>
       /// <returns>A a valid number</returns>
        public static double ValidateOperand()
        {
            double operand;

            if (double.TryParse(Console.ReadLine(), out operand))
            {
                return operand;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");
                Console.Write("Enter a number: ");
                Thread.Sleep(2500);
                ValidateOperand();
            }
            Console.Clear();
            return operand;
        }

        /// <summary>
        /// Ensures user input is a valid mathematical operator,
        /// input must be either of these(+,/,*,-).
        /// </summary>
        /// <param name="@operator">represents user input</param>
        /// <returns>A valid mathematical operator</returns>
        public static ConsoleKeyInfo ValidateOperator()
        {
            ConsoleKeyInfo @operator = Console.ReadKey();
            Console.Write("\n");

            if (@operator.Key != ConsoleKey.Add && @operator.Key != ConsoleKey.Subtract && @operator.Key != ConsoleKey.Divide && @operator.Key != ConsoleKey.Multiply)
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");
                Console.Write("Enter a mathematical Operator: ");
                Thread.Sleep(2500);
                ValidateOperator();
            }
            Console.Clear();
            return @operator;
        }
    }
}