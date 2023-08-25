using System;
using Spectre.Console;

namespace ConsoleCalculator
{
    /// <summary>
    /// Calculator engine.
    /// </summary>
    internal static class Calculations
    {
        private static double _result;

        /// <summary>
        /// Perform calculation, using two operands and an operator.
        /// </summary>
        /// <param name="firstOperand"></param>
        /// <param name="secondOperand"></param>
        /// <param name="operator"></param>
        public static void DoCalculations(double firstOperand, double secondOperand, ConsoleKeyInfo @operator)
        {
            switch (@operator.Key)
            {
                case ConsoleKey.Add:
                    _result = firstOperand + secondOperand;
                    Console.WriteLine($"{firstOperand} + {secondOperand} = ");
                    break;
                case ConsoleKey.Subtract:
                    _result = firstOperand - secondOperand;
                    Console.WriteLine($"{firstOperand} - {secondOperand} = ");
                    break;
                case ConsoleKey.Multiply:
                    _result = firstOperand * secondOperand;
                    Console.WriteLine($"{firstOperand} * {secondOperand} = ");
                    break;
                case ConsoleKey.Divide:
                    while (secondOperand == 0)
                    {
                        secondOperand = Validations.ValidateDivisor(firstOperand, secondOperand);
                    }
                    _result = firstOperand / secondOperand;
                    Console.WriteLine($"{firstOperand} / {secondOperand} = ");
                    break;
            }
            Console.Write("\n" + _result);
        }

        /// <summary>
        /// Perform another calculation using the result
        /// of the previous calculation.
        /// </summary>
        public static void ReCalculate()
        {
            // Infinite loop
            while (true)
            {
                if (AnsiConsole.Confirm("\ndo you want to continue?"))
                {
                    Console.Clear();
                    ConsoleKeyInfo @operator = Validations.ValidateOperator();
                    double firstOperand = _result;
                    double secondOperand = Validations.ValidateOperand();
                    Console.Clear();
                    DoCalculations(firstOperand, secondOperand, @operator);
                }
                else
                {
                    ExitCalculator.CloseCalculator();
                    break;
                }
              
            }
        }
    }
}