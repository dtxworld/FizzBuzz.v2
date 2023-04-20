using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperFizzBuzz;
using System.Collections.Generic;

namespace SuperFizzBuzzTests
{
    [TestClass]
    public class TestExtension
    {
        /// <summary>
        /// Validate FrogDuck token if equal to 52
        /// </summary>
        [TestMethod]
        public void FizzBuzzCheck_FrogDuckOutput_ReturnsTrue()
        {
            var tokenList = new List<(int, string)>
                              {
                                  (4, "Frog"),
                                  (13, "Duck"),
                                  (9, "Chicken")
                              };

            var expected = "FrogDuck";
            var result = Extensions.FizzBuzzCheck(52, tokenList);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Validate FrogChicken token if equal to 36
        /// </summary>
        [TestMethod]
        public void FizzBuzzCheck_FrogChickenOutput_ReturnsTrue()
        {
            var tokenList = new List<(int, string)>
                              {
                                  (4, "Frog"),
                                  (13, "Duck"),
                                  (9, "Chicken")
                              };

            var expected = "FrogChicken";
            var result = Extensions.FizzBuzzCheck(36, tokenList);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Validate FrogDuckChicken token if equal to 468
        /// </summary>
        [TestMethod]
        public void FizzBuzzCheck_FrogDuckChickenOutput_ReturnsTrue()
        {
            var tokenList = new List<(int, string)>
                              {
                                  (4, "Frog"),
                                  (13, "Duck"),
                                  (9, "Chicken")
                              };

            var expected = "FrogDuckChicken";
            var result = Extensions.FizzBuzzCheck(468, tokenList);
            Assert.AreEqual(expected, result);
        }
    }
}