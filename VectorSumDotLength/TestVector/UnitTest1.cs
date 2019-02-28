using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            var data1 = new Vector2D("1,3");
            var data2 = new Vector2D("3,5");
            var result = data1.Sum(data2);
            string resultExpected = "[4,8]";

            Assert.AreEqual(result.ToString(), resultExpected);
        }
        [TestMethod]
        public void TestMethodDot()
        {
            var data1 = new Vector2D("1,3");
            var data2 = new Vector2D("3,5");
            var result = data1.Dot(data2);
            int resultExpected = 18;

            Assert.AreEqual(result, resultExpected);
        }
        [TestMethod]
        public void TestMethodLength()
        {
            var data1 = new Vector2D("1,4");
            var result = data1.Length();
            double resultExpected = Math.Sqrt(17);

            Assert.AreEqual(result, resultExpected);
        }
        [TestMethod]
        public void TestMethodSumNotEquals()
        {
            var data1 = new Vector2D("1,3");
            var data2 = new Vector2D("3,5");
            var result = data1.Sum(data2);
            string resultExpected = "[p,l]";

            Assert.AreNotEqual(result.ToString(), resultExpected);
        }
        [TestMethod]
        public void TestMethodLengthNotEquals()
        {
            var data1 = new Vector2D("1,4");
            var result = data1.Length();
            double resultExpected = Math.Sqrt(15);

            Assert.AreNotEqual(result, resultExpected);
        }

    }
}
