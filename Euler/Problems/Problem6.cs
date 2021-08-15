using System;
using System.ComponentModel;

namespace Euler
{
    [Description("Sum square difference")]
    public class Problem6 : AbstractProblem
    {

        //The sum of the squares of the first ten natural numbers is,
        //1^2 + 2@2 + ... + 10^2 = 385

        //The square of the sum of the first ten natural numbers is,
        //(1 + 2 + ... + 10)2 = 552 = 3025

        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        public override void Execute()
        {
            double sum = 0;
            double sumOfNumberSquare = 0;
            double squareOfSum = 0;
            double max = 0;

            Console.WriteLine("Please enter the max in series : ");
            max = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= max; i++)
            {
                sum += i;
                sumOfNumberSquare = sumOfNumberSquare + Math.Pow(i, 2);
            }

            squareOfSum = Math.Pow(sum, 2);

            Console.WriteLine($" The difference is : { squareOfSum} - { sumOfNumberSquare} = {squareOfSum - sumOfNumberSquare }");

        }


    }
}
