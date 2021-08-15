using System;

namespace Euler
{
    class Problem3 : AbstractProblem
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
