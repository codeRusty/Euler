using System;

namespace Euler
{
    class Problem3 : IProblem
    {
        long x = 13195;
        public void Execute()
        {

            for (long i = 2; i < x; i++)
            {
                if (x % i == 0 && IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public bool IsPrime(long number)
        {
            long count = 0;
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count > 0)
                return false;
            return true;
        }
    }
}
