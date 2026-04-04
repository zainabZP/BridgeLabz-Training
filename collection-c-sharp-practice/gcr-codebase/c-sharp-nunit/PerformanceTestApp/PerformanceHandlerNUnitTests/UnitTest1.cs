using NUnit.Framework;
using PerformanceHandlerApp;
using System;

namespace PerformanceHandlerNUnitTests
{
    [TestFixture]
    public class Test1
    {
        private PerformanceHandler handler;

        [SetUp]
        public void Setup()
        {
            handler = new PerformanceHandler();
        }

        [Test, Timeout(2000)] // fail if longer than 2 seconds
        public void Test_LongRunningTask_Timeout()
        {
            handler.LongRunningTask(); // This will fail because it takes 3 seconds
        }
    }
}
