using System;
using ConsoleAppSonar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonServices.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1, b = 4;
            Services ss = new Services();
            Assert.AreEqual(9, ss.Add(a,b));
        }
    }
}
