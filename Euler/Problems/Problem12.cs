using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Euler.Problems
{
    [Description("Highly divisible triangular number")]
    public class Problem12 : AbstractProblem
    {

        public override void Execute()
        {
            PermormanceMatrix(Solve);
        }

        public void Solve()
        {
            int requiredFactor = 200;
            for (int i = 0; ; i++)
            {
                int n = i * (i + 1) / 2;

                List<int> factors = GetFactors(n);
                if (factors.Count >= requiredFactor)
                {
                    foreach (int factor in factors)
                    {
                        Console.Write(factor + ",");
                    }
                    Console.WriteLine("Number Is: " + n);
                    break;
                }
               
            }
        }

        private List<int> GetFactors(int n)
        {
            List<int> result = new List<int>();
            for (int j = 1; j < n; j++)
            {
                if (n % j == 0)
                    result.Add(j);
            }
            return result;
        }
    }
}
