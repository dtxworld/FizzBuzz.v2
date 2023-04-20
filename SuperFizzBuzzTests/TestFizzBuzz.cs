using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class TestFizzBuzz
    {
        /// <summary>
        /// Test output 2 through 35
        /// </summary>
        [TestMethod]
        public void GetRange_TwoPositiveNumbers_ReturnsRange()
        {
            var expected = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
            var result = FizzBuzz.GetRange(Tuple.Create(2, 35));
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test output -1 through -35
        /// </summary>
        [TestMethod]
        public void GetRange_TwoNegativeNumbers_ReturnsRange()
        {
            var expected = new List<int> { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, -11, -12, -13, -14, -15, -16, -17, -18, -19, -20, -21, -22, -23, -24, -25, -26, -27, -28, -29, -30, -31, -32, -33, -34, -35 };
            var result = FizzBuzz.GetRange(Tuple.Create(-1, -35));
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test output for user supplied set of integers
        /// ToDo: Fizzbuzz output or only output the ’user supplied set of integers’? (unused)
        /// </summary>
        [TestMethod]
        public void GetUserSuppliedOutput_UserSuppliedSetOfIntegers_OutputsList()
        {
            var expected = new List<int> { 3, 100, 64, 21, 0, 49 };
            var result = FizzBuzz.GetUserSuppliedOutput(new List<int> { 3, 100, 64, 21, 0, 49 });
            CollectionAssert.AreEqual(expected, result);
        }
    }
}