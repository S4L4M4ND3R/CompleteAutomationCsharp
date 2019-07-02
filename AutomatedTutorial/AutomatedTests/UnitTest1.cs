using System;
using AutomatedTutorial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Class1();
            c.Go();
        }
    }
}
