using System;
using System.ComponentModel;

namespace Euler
{
    [Description("Find the sum of Fibonacci sequence the even-valued terms.")]
    public class Problem2 : AbstractProblem
    {
        public override void Execute()
        {

            StartStopwatch();
            Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms");

            int first = 1;
            int second = 2;

            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i = 1; i < 10; i++)
            {
                int temp = first + second;
                first = second;
                second = temp;

                if (temp % 2 == 0)
                    Console.WriteLine(temp);
                else
                    i--;
            }
            StopStopwatch();
            LogElapsedTime();
        }
    }
}
