using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject2
{
    [TestClass]
    public class UnitTest21
    {
        private TestContext m_testContext;

        public TestContext TestContext

        {

            get { return m_testContext; }

            set { m_testContext = value; }

        }

        [TestMethod]
        public void TestProjectPassTestMethod1()
        {
        }

        [TestMethod]
        public void TestResultWithAttachment()
        {
            Console.WriteLine("Want this as my attachment.");
            Console.WriteLine("Want this as my attachment.");
            Debug.Write("Want this as my attachment");
            Assert.AreEqual(1, 0);
        }
    }
}
