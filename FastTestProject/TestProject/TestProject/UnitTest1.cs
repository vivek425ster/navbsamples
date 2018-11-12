using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        public static int i = 0;
        
        [TestMethod]
        [Owner("some1")]
        [Priority(1)]
        public void WillPassOnReRun1()
        {
            Assert.IsTrue(i++ % 4 == 0);
        }


        [TestMethod]
        [Owner("some2")]
        [Priority(2)]
        public void WillPassOnReRun11()
        {
            Assert.IsTrue(i++ % 4 == 0);
        }
        
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual(0,1);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(0,1);
        }

        [TestMethod]
        public void TestMethod33()
        {
            Assert.AreEqual(0,1);
        }
    }
}
