using Microsoft.VisualStudio.TestTools.UnitTesting;
using PerformanceHandlerApp;
using System;

namespace PerformanceHandlerMSTests
{
    [TestClass]
    public class Test1
    {
        private PerformanceHandler handler;

        [TestInitialize]
        public void Setup()
        {
            handler = new PerformanceHandler();
        }

        [TestMethod]
        [Timeout(2000)] // fail if longer than 2 seconds
        public void Test_LongRunningTask_Timeout()
        {
            handler.LongRunningTask(); // This will fail because it takes 3 seconds
        }
    }
}
