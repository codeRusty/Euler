using System;
using System.Linq;
using static Euler.Enums;

namespace Euler
{
    public class Creator
    {
        public static IProblem Create(int selectedProblem)
        {
            IProblem instance = null;

            var problemName = "Problem" + selectedProblem;

            var problems = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(assembly => assembly.GetTypes())
                    .Where(type => type.IsSubclassOf(typeof(AbstractProblem)));

            foreach (var problem in problems)
            {
                if (problem.Name == problemName)
                {
                    instance = (IProblem)Activator.CreateInstance(problem);
                    break;
                }
            }
            if (instance == null)
            {
                throw new Exception("Invalid Problem stated.");
            }

            return instance;
        }
    }
}
