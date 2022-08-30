using System;
using System.Threading;

namespace ConsoleCalculator
{
    class ValidateUserInputs : Calculations
    {

        private double _numberEntered;
        public ConsoleColor exitColor = Console.ForegroundColor;


        // Check if first number entered is a valid numeral.
        public void ValidateFirstNumberInput()
        {

            InputString = Console.ReadLine();

            if (double.TryParse(InputString, out _numberEntered))
                FirstNumber = _numberEntered;

            else
            {
                Console.WriteLine("\nWrong input!");
                Console.Write("Enter a number: ");

                Thread.Sleep(2500);
                Console.Clear();

                ValidateFirstNumberInput();
            }

            Console.Clear();
        }

        // Check if operator entered is valid mathematical operator.
        public void ValidateOperator()
        {

            ConsoleKeyInfo @operator;
            @operator = Console.ReadKey();

            Console.Write("\n");
            Operator = @operator;

            if (@operator.Key != ConsoleKey.Add && @operator.Key != ConsoleKey.Subtract && @operator.Key != ConsoleKey.Divide && @operator.Key != ConsoleKey.Multiply)
            {
                Console.WriteLine("\nWrong input!");
                Console.Write("Enter a valid mathematical Operator: ");

                Thread.Sleep(2500);
                Console.Clear();

                ValidateOperator();

            }

            Console.Clear();
        }



        // Check if second number entered is a valid numeral.
        public void ValidateSecondNumberInput()
        {

            InputString = Console.ReadLine();

            if (double.TryParse(InputString, out _numberEntered))
                SecondNumber = _numberEntered;

            else
            {
                Console.WriteLine("\nWrong input!");
                Console.Write("Enter a number: ");

                Thread.Sleep(2500);
                Console.Clear();

                ValidateSecondNumberInput();
            }

            Console.Clear();

        }


        // Check  if user would like to  perform another calculation
        // or exit the application.
        public void ExitApplication()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\tPerform a new Calculation\n\t\t  Y/N ? ");
            Console.ForegroundColor = exitColor;

            ConsoleKeyInfo exitApp = Console.ReadKey();
            Console.Clear();

            switch (exitApp.Key)
            {
                case ConsoleKey.Y:

                    // Calling this method to perform another calculation.                   
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
