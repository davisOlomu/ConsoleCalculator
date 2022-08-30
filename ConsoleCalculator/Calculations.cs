using System;

namespace ConsoleCalculator
{
    public abstract class Calculations
    {

        public double FirstNumber { get; protected set; }
        public double SecondNumber { get; protected set; }
        public ConsoleKeyInfo Operator { get; set; }
        public string InputString { get; protected set; }

        private double _result;



        // Performing calculations based on the operator
        // Entered by the user
        public void DoCalculations()
        {

            switch (Operator.Key)
            {
                case ConsoleKey.Add:
                    _result = FirstNumber + SecondNumber;

                    Console.WriteLine($"{FirstNumber} + {SecondNumber} = ");
                    break;

                case ConsoleKey.Subtract:
                    _result = FirstNumber - SecondNumber;

                    Console.WriteLine($"{FirstNumber} - {SecondNumber} = ");
                    break;

                case ConsoleKey.Multiply:
                    _result = FirstNumber * SecondNumber;

                    Console.WriteLine($"{FirstNumber} * {SecondNumber} = ");
                    break;

                case ConsoleKey.Divide:

                    // Check that the number zero is not entered
                    // As a second number when performing a division.

                    while (SecondNumber == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        Console.Write("Re-Enter number and press enter: ");

                        InputString = Console.ReadLine();
                        Console.Clear();

                        if (double.TryParse(InputString, out double divisorNumber))
                            SecondNumber = divisorNumber;
                    }

                    _result = FirstNumber / SecondNumber;

                    Console.WriteLine($"{FirstNumber} / {SecondNumber} = ");
                    break;

            }


            Console.WriteLine(Environment.NewLine);
            Console.Write(_result);

            FirstNumber = _result;

        }
    }

}
