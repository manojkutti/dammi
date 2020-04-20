using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10, y = 20;
            int expected = 30;
            int actual=ConsoleApp.Program.Add(x,y);
            Assert.AreEqual(expected, actual);

        }
    }
}
