using System;
using static ConsoleCalculator.Calculations;

namespace ConsoleCalculator
{
    /// <summary>
    /// Allows the user to continue calculating without resetting calculator.
    /// </summary>
    internal static class ReCalculation
    {
        /// <summary>
        /// First operand for a new calculation.
        /// </summary>
        public static double Result { get; set; }

        /// <summary>
        /// Perform a new calculation using the result of the
        /// previous calculation as the first operand
        /// for the new calculation.
        /// </summary>
        public static void ReCalculate()
        {
            bool isRecalculating = true;

            while (isRecalculating)
            {
                ConsoleKeyInfo option = Console.ReadKey();

                if (option.Key == ConsoleKey.Add || option.Key == ConsoleKey.Subtract || option.Key == ConsoleKey.Multiply || option.Key == ConsoleKey.Divide)
                {
                    double firstOperand = Result;
                    double secondOperand = Validations.ValidateOperand();
                    Console.Clear();
                    DoCalculations(firstOperand, secondOperand, option);
                }
                else
                {
                    Console.Clear();
                    Exit.Exiting();
                    isRecalculating = false;
                }
            }
        }
    }
}
