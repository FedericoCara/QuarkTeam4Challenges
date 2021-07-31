using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Easy;

namespace QuarkChallengesTests
{
    [TestClass]
    public class FindMissingNumberTest
    {
        [TestMethod]
        public void FindMissingNumberMethod()
        {
            // MissingNum([10, 5, 1, 2, 4, 6, 8, 3, 9]) = 7

            int correctResult = 7;
            int[] numbers = new[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 };
            var result = FindMissingNumber.FindMissingNumberMethod(numbers);

            Assert.AreEqual(correctResult, result);


        }
    }
}
