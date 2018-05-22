using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppSonar.Test
{
    [TestClass]
    public class MyConfigTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyConfig mc = new MyConfig();
            mc.Initialize();
        }
    }
}
