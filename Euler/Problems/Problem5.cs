using System;
using System.ComponentModel;

namespace Euler.Problems
{
    [Description("Smallest multiple")]
    public class Problem5 : AbstractProblem
    {
        public override void Execute()
        {
            Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");

            int c = 0;
            for (int i = 2; i < 1000000000; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (c >= 20)
                {
                    Console.WriteLine(i);
                    break;
                }

                c = 0;
            }
            Console.WriteLine("Complete");
        }
    }
}
