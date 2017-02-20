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

        
        
        
        public bool checkIfDivBy3(int number)
        {
            bool result = false;
            if (number % 3 == 0) 
            {
                result = true;

            }
            return result;
        }

        public bool checkIfDivBy5(int number)
        {
            bool result = false;
            if (number % 5 == 0)
            {
                result = true;
            }
            return result;
        }

        public String checkIfFizzBuzz(int number)
        {
            String result = "";
            switch(checkIfDivBy3(number))
            {
                case true:
                    if (checkIfDivBy5(number))
                    {
                        result = "FizzBuzz";
                    }
                    else
                    {
                        result = "Fizz";
                    }
                    break;
                case false:
                    if (checkIfDivBy5(number))
                    {
                        result = "Buzz";
                    }break;
            }
            return result;
           
        }
    }
}
