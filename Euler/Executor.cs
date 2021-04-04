namespace Euler
{
    class Executor
    {
        IProblem context;
        public Executor(IProblem problem)
        {
            problem.Execute();
        }
    }
}
