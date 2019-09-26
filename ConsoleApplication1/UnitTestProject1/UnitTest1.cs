using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.isOdd(3);
            Assert.AreEqual(true, result3);
            bool result4 = Program.isOdd(4);
            Assert.AreEqual(false, result4);

        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result3 = Program.isEven(3);
            Assert.AreEqual(false, result3);
            bool result4 = Program.isEven(4);
            Assert.AreEqual(true, result4);
        }
       
    }
}
