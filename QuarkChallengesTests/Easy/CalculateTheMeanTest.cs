using System;
using System.Collections.Generic;
using System.Text;
using QuarkTeam4Challenges.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuarkChallengesTests
{
    [TestClass]
    public class CalculateTheMeanTest
    {
        [TestMethod]
        public void CalculateTheMeanMethod()
        {
            var numbers = new int[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
            var correctResult = 2.55;
            var result = CalculateTheMean.Calculate(numbers);

            Assert.AreEqual(result, correctResult);
        }
    }
}
