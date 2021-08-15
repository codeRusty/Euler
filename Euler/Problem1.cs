using System;

namespace Euler
{
    // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    // Find the sum of all the multiples of 3 or 5 below 1000.
    class Problem1 : AbstractProblem
    {
        int sum = 0;
        public override void Execute()
        {
            // Getting the values required.
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below x.");
            Console.Write("What is the value of x (should be more than 2) : ");
            string input = Console.ReadLine();

            StartStopwatch();

            int output = 0;
            bool isInt = int.TryParse(input, out output);
            if (isInt && output > 2)
            {
                Console.Write("The sum of ");

                for (int i = 1; i < output; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        Console.Write($"{i}, ");
                        sum += i;
                    }
                }


                Console.WriteLine("is " + sum);
            }
            else
            {
                Console.WriteLine("Improper Argument");
            }
            StopStopwatch();
            LogElapsedTime();
        }
    }
}
