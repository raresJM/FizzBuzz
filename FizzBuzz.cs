using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz2
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestCheckDivBy3_GoodScenario_01()
        {
            Assert.IsTrue(checkIfDivBy3(3));
        }
        [TestMethod]
        public void TestCheckDivBy3_GoodScenario_02()
        {
            Assert.IsTrue(checkIfDivBy3(15));
        }

        [TestMethod]
        public void TestCheckDivBy3_BadScenario_01()
        {
            Assert.IsFalse(checkIfDivBy3(2));
        }

        [TestMethod]
        public void TestCheckDivBy5_GoodScenario_01()
        {
            Assert.IsTrue(checkIfDivBy5(5));
        }
        [TestMethod]
        public void TestCheckDivBy5_GoodScenario_02()
        {
            Assert.IsTrue(checkIfDivBy5(15));
        }
        [TestMethod]
        public void TestCheckDivBy5_BadScenario_01()
        {
            Assert.IsFalse(checkIfDivBy5(2));
        }

        [TestMethod]
        public void TestFizzBuzz_Fizz()
        {
            Assert.IsFalse(checkIfFizzBuzz(3));
        }
        [TestMethod]
        public void TestFizzBuzz_Buzz()
        {
            Assert.IsFalse(checkIfFizzBuzz(5));
        }
        [TestMethod]
        public void TestFizzBuzz_FizzBuzz()
        {
            Assert.IsFalse(checkIfFizzBuzz(15));
        }
        [TestMethod]
        public void TestFizzBuzz_NotFizzNotBuzz()
        {
            Assert.IsFalse(checkIfFizzBuzz(2));
        }

    }
}
