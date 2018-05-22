using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppSonar.Test
{
    [TestClass]
    public class ServicesTest
    {
        [TestMethod]
        public void ShouldAddWhenAIsSmallerThanB()
        {
            int a = 1;
            int b = 3;
            Services s = new Services();
            Assert.AreEqual(a + b, s.Calculate(a, b));
        }

        [TestMethod]
        public void ShouldSubWhenAIsGreatThanB()
        {
            int a = 4;
            int b = 3;
            Services s = new Services();
            Assert.AreEqual(a - b, s.Calculate(a, b));            
        }
    }
}
