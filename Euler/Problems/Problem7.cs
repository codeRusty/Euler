using System;
using System.ComponentModel;

namespace Euler
{

    //Problem 7
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    //What is the 10001st prime number?
    [Description("10001st prime")]
    public class Problem7 : AbstractProblem
    {
        public override void Execute()
        {

            Console.WriteLine("Find the nth prime number \n");
            int n = Convert.ToInt32(Console.ReadLine());

            StartStopwatch();
            int m = n;

            for (int i = 2; i < Int32.MaxValue; i++)
            {
                if (Cognition.IsPrime(i))
                    --n;
                if (n == 0)
                {
                    Console.WriteLine($"The {m}th prime number is: {i}");
                    break;
                }
            }

            StopAndLogElapsedTime();
        }
    }
}
