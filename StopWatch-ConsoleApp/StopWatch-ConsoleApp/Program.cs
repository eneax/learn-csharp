using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopWatch.Start(DateTime.Now);

                for (var j = 0; j <= 1000; j++)
                {
                    Thread.Sleep(1);
                }

                // stopWatch.Start(DateTime.Now);

                stopWatch.Stop(DateTime.Now);

                Console.WriteLine(stopWatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }

    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool running = false;

        public void Start(DateTime start)
        {
            if (!running)
            {
                StartTime = start;
                running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }
        }

        public void Stop(DateTime stop)
        {
            if (running)
            {
                EndTime = stop;
                running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            return EndTime - StartTime;
        }
    }
}
