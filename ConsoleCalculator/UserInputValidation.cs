using System;
using System.Threading;

namespace ConsoleCalculator
{
    internal class UserInputValidation
    {
        // Verify that user input is a valid arithemetic number.
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
        // Verify that user input is a valid mathematical opeartor.
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