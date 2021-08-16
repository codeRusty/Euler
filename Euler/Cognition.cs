namespace Euler
{
    public static class Cognition
    {
        public static bool IsPrime(long number)
        {
            if (number == 1)
                return false;

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
