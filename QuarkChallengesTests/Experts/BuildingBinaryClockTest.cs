using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Expert;

namespace QuarkChallengesTests
{
    [TestClass]
    public class BuildingBinaryClockTest
    {

        [TestMethod]
        public void TestBinaryClock() 
        {
            var correctResult = new string[] { " 0 0 0", " 00101", "000101", "101011" };
            string time = "10:37:49";
            Console.WriteLine($"Input: {time}");

            var result = BuildingBinaryClock.BinaryClock("10:16:17");

            CollectionAssert.AreEqual(result, correctResult);
        }
        
    }
}
