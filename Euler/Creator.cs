using static Euler.Enums;

namespace Euler
{
    public class Creator
    {
        public static IProblem Create(Enums.Problem problem)
        {
            switch (problem)
            {
                case Enums.Problem.Problem1:
                    return new Problem1();
                case Enums.Problem.Problem2:
                    return new Problem2();
                case Enums.Problem.Problem3:
                    return new Problem3();
                case Enums.Problem.Problem4:
                    return new Problem4();
                case Enums.Problem.Problem5:
                    return new Problem5();
                case Enums.Problem.Problem6:
                    return new Problem6();
                case Enums.Problem.Problem7:
                    return new Problem7();
                case Enums.Problem.Problem8:
                    return new Problem1();
                case Enums.Problem.Problem9:
                    return new Problem1();
                default:
                    return new Problem1();
            }
        }
    }
}
