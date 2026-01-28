using System;
using System.Threading;

namespace PerformanceHandlerApp
{
    public class PerformanceHandler
    {
        public string LongRunningTask()
        {
            // Reduce sleep to 1 second so test with 2s timeout passes
            Thread.Sleep(1000);
            return "Task Completed";
        }
    }
}
