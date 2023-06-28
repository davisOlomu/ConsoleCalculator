using System;

namespace ConsoleCalculator
{
    internal class Calculations
    {
        // Calculations using basic mathematical operators(+,-,*,/)
        public static void DoCalculations(double firstOperand, double secondOperand, ConsoleKeyInfo @operator)
        {
            double result = 0;
            switch (@operator.Key)
            {
                case ConsoleKey.Add:
                    result = firstOperand + secondOperand;
                    Console.WriteLine($"{firstOperand} + {secondOperand} = ");
                    break;
                case ConsoleKey.Subtract:
                    result = firstOperand - secondOperand;
                    Console.WriteLine($"{firstOperand} - {secondOperand} = ");
                    break;
                case ConsoleKey.Multiply:
                    result = firstOperand * secondOperand;
                    Console.WriteLine($"{firstOperand} * {secondOperand} = ");
                    break;
                case ConsoleKey.Divide:
                    // Cannot divide by zero
                    while (secondOperand == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        Console.Write("Re-Enter number and press enter: \n\n");
                        Console.Write($"{firstOperand}/");
                        Console.Clear();
                        secondOperand = double.Parse(Console.ReadLine());
                    }
                    result = firstOperand / secondOperand;
                    Console.WriteLine($"{firstOperand} / {secondOperand} = ");
                    break;
            }
            Console.WriteLine(Environment.NewLine);
            Console.Write(result);

            // ReUse result for another calculation
            ReCalculation.Result = result;
        }
    }
}
