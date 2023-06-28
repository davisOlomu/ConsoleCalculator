using System;
using static ConsoleCalculator.Calculations;

namespace ConsoleCalculator
{
    internal class ReCalculation
    {
        // Result of the previous calculation.
        public static double Result { get; set; }

        // Prompts the user to either continue calculating or exit the App.
        public static void ReCalculate()
        {
            bool isRecalculating = true;

            while (isRecalculating)
            {
                ConsoleKeyInfo option = Console.ReadKey();

                if (option.Key == ConsoleKey.Add || option.Key == ConsoleKey.Subtract || option.Key == ConsoleKey.Multiply || option.Key == ConsoleKey.Divide)
                {
                    double firstOperand = Result;
                    double secondOperand = UserInputValidation.ValidateOperand();
                    Console.Clear();
                    DoCalculations(firstOperand, secondOperand, option);
                }
                else
                {
                    Console.Clear();
                    ExitCalculator.CloseCalculator();
                    isRecalculating = false;
                }
            }
        }
    }
}
