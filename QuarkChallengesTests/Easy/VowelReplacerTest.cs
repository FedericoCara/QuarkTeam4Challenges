using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Easy;

namespace QuarkChallengesTests
{
    [TestClass]
    public class VowelReplacerTest
    {
        [TestMethod]
        public void VowelReplacerMethod()
        {
            string correctResult = "th# ##rdv#rk";

            var result = VowelReplacer.VowelReplacerMethod("the aardvark", '#');

            Assert.AreEqual(correctResult, result);
        }
    }
}
