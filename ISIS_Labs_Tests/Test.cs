using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2_Tests
{
    [TestClass]
    public class tests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Lab_1.methods.GetCountWordsByLength("Мама мыла раму, мама мама мама", 4), (6));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Lab_1.methods.sum(3, 3), 6);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Lab_1.methods.CountSPACE("Ехал Грека через реку   видит в реке рака"), 9);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.IsTrue(Lab_1.methods.Palindrom("шалаш"));
        }

        [TestMethod]
        public void Test6()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.AreEqual(Lab_1.methods.ArrLen(numbers), 10);
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(Lab_1.methods.NotEqueal(5, 6));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(Lab_1.methods.dev(10, 2), 5);
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(Lab_1.methods.dif(5, 6), -1);
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(Lab_1.methods.mult(4, 3), 12);
        }

        [TestMethod]
        public void Test3()
        {
            var num = 10;
            Assert.AreEqual(num, 10);
        }
    }
}

