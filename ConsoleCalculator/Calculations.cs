using System;

namespace ConsoleCalculator
{
    internal class Calculations
    {
        /// <summary>
        /// Perform calculation using the basic arithemetic operators
        /// </summary>
        /// <param name="firstOperand"></param>
        /// <param name="secondOperand"></param>
        /// <param name="operator"></param>
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

            ReCalculation.Result = result;
        }
    }
}
