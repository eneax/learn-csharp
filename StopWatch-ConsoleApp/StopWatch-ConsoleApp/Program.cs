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
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;  // false by default

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (_running)
            {
                _endTime = DateTime.Now;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
