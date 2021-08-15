using System.ComponentModel;

namespace Euler.Problems
{

    [Description("Special Pythagorean triplet")]
    public class Problem9 : AbstractProblem
    {
        public override void Execute()
        {

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= 1000; j++)
                {
                    for (int k = 1; k <= 1000; k++)
                    {
                        if ((i * i) + (j * j) == (k * k) && i + j + k == 1000)
                        {
                            System.Console.WriteLine(i + " " + j + " " + k);
                            break;
                        }
                    }
                }
            }
        }
    }
}
