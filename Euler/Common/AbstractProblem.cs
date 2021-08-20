using System;
using System.Diagnostics;

namespace Euler
{
    public abstract class AbstractProblem : IProblem
    {
        private Stopwatch _clock;
        public void StartStopwatch()
        {
            _clock = Stopwatch.StartNew();
        }
        public void StopStopwatch()
        {
            _clock.Stop();
        }

        public void LogElapsedTime()
        {
            var time = _clock.ElapsedMilliseconds;
            if (time > 1000)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"--------------------------");
                Console.WriteLine($"Execution time : {time} ms ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"--------------------------");
                Console.WriteLine($"Execution time : {time}ms ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        public void StopAndLogElapsedTime()
        {
            StopStopwatch();
            LogElapsedTime();
        }

        public abstract void Execute();

        public void PermormanceMatrix(Action function)
        {
            StartStopwatch();
            function();
            StopStopwatch();
            LogElapsedTime();
            LogMemoryUsed();
        }

        private void LogMemoryUsed()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Space Allocated: {GC.GetTotalAllocatedBytes()/1000} KB ");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
