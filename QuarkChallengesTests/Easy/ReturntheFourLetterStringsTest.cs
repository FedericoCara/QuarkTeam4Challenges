using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Easy;

namespace QuarkChallengesTests
{
    [TestClass]
    public class ReturntheFourLetterStringsTest
    {
        [TestMethod]
        public void ReturntheFourLetterStringsMethod()
        {
            string [] words = { "Tomato", "Potato", "Pair" };
            string [] correctResult = { "Pair" };

            var result = ReturnFourLetterStrings.FourLetterStrings(words);

            CollectionAssert.AreEqual(result, correctResult);

        }
    }
}
