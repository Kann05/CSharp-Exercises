using Fizz_Buzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        public void CheckInputValue_WhenDiv3_ReturnsFizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]

        public void CheckInputValue_WhenDiv5_ReturnBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]

        [DataRow(15)]

        public void CheckInputValue_WhenDividedBy3And5_ReturnFizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
