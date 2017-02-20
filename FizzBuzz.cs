using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz2
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void TestCheckDivByNumber_GoodScenario_01()
        {
            Assert.IsTrue(checkIfDivByNumber(3,3));
        }
        [TestMethod]
        public void TestCheckDivByNumber_GoodScenario_02()
        {
            Assert.IsTrue(checkIfDivByNumber(15,3));
        }
        [TestMethod]
        public void TestCheckDivByNumber_GoodScenario_03()
        {
            Assert.IsTrue(checkIfDivByNumber(5, 5));
        }
        [TestMethod]
        public void TestCheckDivByNumber_GoodScenario_04()
        {
            Assert.IsTrue(checkIfDivByNumber(15, 5));
        }

        [TestMethod]
        public void TestCheckDivByNumber_BadScenario_01()
        {
            Assert.IsFalse(checkIfDivByNumber(2,3));
        }
        [TestMethod]
        public void TestCheckDivByNumber_BadScenario_02()
        {
            Assert.IsFalse(checkIfDivByNumber(2, 5));
        }

        [TestMethod]
        public void TestFizzBuzz_Fizz()
        {
            Assert.AreEqual("Fizz", checkIfFizzBuzz(3));
        }
        [TestMethod]
        public void TestFizzBuzz_Buzz()
        {
            Assert.AreEqual("Buzz", checkIfFizzBuzz(5));
        }
        [TestMethod]
        public void TestFizzBuzz_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", checkIfFizzBuzz(15));
        }
        [TestMethod]
        public void TestFizzBuzz_NotFizzNotBuzz()
        {
            Assert.AreEqual("", checkIfFizzBuzz(2));
        }

        
        public bool checkIfDivByNumber(int number, int divizor)
        {
            bool result = false;
            if (number % divizor == 0) 
            {
                result = true;

            }
            return result;
        }

        public String checkIfFizzBuzz(int number)
        {
            String result = "";
            if (checkIfDivByNumber(number, 15))
            {
                result = "FizzBuzz";
            }
            else if (checkIfDivByNumber(number, 3))
            {
                result = "Fizz";
            }
            else if (checkIfDivByNumber(number, 5))
            {
                result = "Buzz";
            } 
            return result;
           
        }
    }
}
