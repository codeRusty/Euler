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
                Console.WriteLine($"Execution time : {time}ms ");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
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
    }
}
