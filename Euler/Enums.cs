using System.ComponentModel;

namespace Euler
{
    public class Enums
    {
        public enum Problem
        {
            [Description("Find the sum of all the multiples of 3 or 5 below x.")]
            Problem1 = 1,
            [Description("Find the sum of Fibonacci sequence the even-valued terms.")]
            Problem2,
            [Description("What is the largest prime factor of the number 600851475143 ")]
            Problem3,
            [Description("Largest palindrome product")]
            Problem4,
            [Description("Smallest multiple")]
            Problem5,
            [Description("Sum square difference")]
            Problem6,
            [Description("10001st prime")]
            Problem7,
            [Description("Largest product in a series")]
            Problem8,
            [Description("Special Pythagorean triplet")]
            Problem9
        }
    }
}
