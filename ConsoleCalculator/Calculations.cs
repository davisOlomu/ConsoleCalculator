using System;

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
            bool isRecalculating = true;

            while (isRecalculating)
            {
                ConsoleKeyInfo @operator = Validations.ValidateOperator();

                if (@operator.Key == ConsoleKey.Add || @operator.Key == ConsoleKey.Subtract || @operator.Key == ConsoleKey.Multiply || @operator.Key == ConsoleKey.Divide)
                {
                    double firstOperand = _result;
                    double secondOperand = Validations.ValidateOperand();
                    Console.Clear();
                    DoCalculations(firstOperand, secondOperand, @operator);
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