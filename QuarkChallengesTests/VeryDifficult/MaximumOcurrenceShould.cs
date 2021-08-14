using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.VeryDificult;

namespace QuarkChallengesTests
{
    /*
     Given a string text. Write a function that returns the character with the highest frequency. 
    If more than 1 character has the same highest frequency, return all those characters as a comma separated string. 
    If there is no repetition in characters, return "No Repetition".
     */

    [TestClass]
    public class MaximumOcurrenceShould
    {

        [TestMethod]
        public void CheckManyOcurrencesOfOneLetter() {
            //Given
            string givenString = "Computer Science";

            //When
            string result = MaximumOcurrence.MaxOccur(givenString);

            //Then
            Assert.AreEqual("e", result);
        }

        [TestMethod]
        public void CheckManyOcurrencesOfManyLetters() {
            //Given
            string givenString = "system admin";

            //When
            string result = MaximumOcurrence.MaxOccur(givenString);

            //Then
            Assert.AreEqual("m, s", result);
        }

        [TestMethod]
        public void CheckNoRepetitions() {
            //Given
            string givenString = "Edabit";

            //When
            string result = MaximumOcurrence.MaxOccur(givenString);

            //Then
            Assert.AreEqual(MaximumOcurrence.NO_REPETITION, result);
        }

        [TestMethod]
        public void CheckEmptySpaceOcurrences() {
            //Given
            string givenString = "the quick brown fox jumps over the lazy dog";

            //When
            string result = MaximumOcurrence.MaxOccur(givenString);

            //Then
            Assert.AreEqual(" ", result);
        }

        [TestMethod]
        public void CheckEmptySpaceAndLetterOcurrences() {
            //Given
            string givenString = " a a";

            //When
            string result = MaximumOcurrence.MaxOccur(givenString);

            //Then
            Assert.AreEqual("a,  ", result);
        }

    }
}
