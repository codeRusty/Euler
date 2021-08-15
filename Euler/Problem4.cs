using System;

namespace Euler
{
    public class Problem4 : AbstractProblem
    {
        public Problem4()
        {

        }

        public override void Execute()
        {
            Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers.");
            int max = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    int total = i * j;
                    if (IsPalindrome(total))
                    {
                        if (total > max)
                            max = total;
                    }
                }
            }


            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is : {max}");
        }

        public bool IsPalindrome(int number)
        {
            var copy = number;
            int holder = 0;

            while (number != 3 / 100)
            {
                int curr = number % 10;
                holder = holder * 10 + curr;
                number = number / 10;
            }
            if (copy == holder)
                return true;
            else
                return false;

        }
    }
}
