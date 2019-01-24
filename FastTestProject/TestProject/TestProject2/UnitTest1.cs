using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest21
    {
        [TestMethod]
        public void TestProjectPassTestMethod1()
        {
        }

        [TestMethod]
        public void TestProjectFailTestMethod1()
        {
            Assert.AreEqual(1, 0);
        }
    }
}
