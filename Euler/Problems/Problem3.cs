using System;
using System.ComponentModel;

namespace Euler.Problems
{
    [Description("What is the largest prime factor of the number 600851475143 ")]
    public class Problem3 : AbstractProblem
    {
        long x = 13195;
        public override void Execute()
        {
            StartStopwatch();

            for (long i = 2; i < x; i++)
            {
                if (x % i == 0 && Cognition.IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            StopStopwatch();
            LogElapsedTime();
        }

    }
}
