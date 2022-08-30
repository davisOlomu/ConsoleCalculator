using System;

namespace ConsoleCalculator
{
    internal class CalculatorDisplay
    {
        public static void Main()
        {

            Console.Title = "Console Calculator";
            Console.SetWindowSize(45, 25);


            var userInputs = new ValidateUserInputs();


            Console.Write("Enter first number and press enter: ");
            userInputs.ValidateFirstNumberInput();

            Console.Write("Enter operator: ");
            userInputs.ValidateOperator();

            Console.Write("Enter second number and press enter: ");
            userInputs.ValidateSecondNumberInput();

            userInputs.DoCalculations();



            bool continueCalculation = true;

            while (continueCalculation)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("\nPress \"End\" key to Reset/Exit claculator.");
                //Console.ForegroundColor = userInputs.exitColor;

                ConsoleKeyInfo userDescisionToContinue = Console.ReadKey();


                if (userDescisionToContinue.Key == ConsoleKey.End)
                {
                    Console.Clear();
                    userInputs.ExitApplication();

                    continueCalculation = false;
                }


                else if (userDescisionToContinue.Key == ConsoleKey.Add || userDescisionToContinue.Key == ConsoleKey.Subtract || userDescisionToContinue.Key == ConsoleKey.Multiply || userDescisionToContinue.Key == ConsoleKey.Divide)
                {
                    Console.Clear();
                    userInputs.Operator = userDescisionToContinue;

                    Console.Write("Enter second number and press enter: ");
                    userInputs.ValidateSecondNumberInput();

                    userInputs.DoCalculations();
                }

                else
                {
                    Console.Clear();
                    userInputs.ExitApplication();

                    continueCalculation = false;
                }

            }

        }
    }

}
