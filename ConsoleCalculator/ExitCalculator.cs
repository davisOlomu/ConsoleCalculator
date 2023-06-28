using System;

namespace ConsoleCalculator
{
    internal class ExitCalculator
    {
        // Exit the calculator
        public static void CloseCalculator()
        {
            Console.Write("\n\n\tPerform a new Calculation\n\t\t Y/N ? ");
            ConsoleKeyInfo option = Console.ReadKey();
            Console.Clear();

            switch (option.Key)
            {
                case ConsoleKey.Y:
                    CalculatorDisplay.Main();
                    break;
                case ConsoleKey.N:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input! Exiting Application.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
