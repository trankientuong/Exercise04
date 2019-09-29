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
        [TestMethod]
        public void TestIsPrime()
        {
            bool result7 = Program.isPrime(7);
            Assert.AreEqual(true, result7);
            bool result6 = Program.isPrime(6);
            Assert.AreEqual(false, result6);
        }
        [TestMethod]
        public void TestSquare()
        {
            int result4 = Program.Square(4);
            Assert.AreEqual(16, result4);
        }
        [TestMethod]
        public void TestCube()
        {
            int result4 = Program.Cube(4);
            Assert.AreEqual(64, result4);
        }
        [TestMethod]
        public void TestPow()
        {
            int result4 = Program.Pow(2,5);
            Assert.AreEqual(32, result4);
        }
        [TestMethod]
        public void TestAbs()
        {
            int result = Program.Abs(4);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestCeil()
        {            
            float result = Program.Ceil((float)3.5);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestFloor()
        {
            float result = Program.Floor((float)3.5);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long result = Program.Factorial(5);
            Assert.AreEqual(120, result);
        }
    }
}
