using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Experts;
using System;
namespace QuarkChallengesTest {
    [TestClass] public class RomanNumeralsTests 
    {
        [TestMethod] public void Returns_1() 
        { 
            int result = RomanNumValidator("I"); 
            Assert.AreEqual(result, 1); 
        }
        [TestMethod] public void Returns_8() 
        { 
            int result = RomanNumValidator("VIII"); 
            Assert.AreEqual(result, 8); 
        }
        [TestMethod] public void Returns_29() 
        { 
            int result = RomanNumValidator("XXIX"); 
            Assert.AreEqual(result, 29); 
        }
        [TestMethod] public void Returns_54() 
        { 
            int result = RomanNumValidator("LIV"); 
            Assert.AreEqual(result, 54); 
        }
        [TestMethod] public void Returns_205() 
        { int result = RomanNumValidator("CCV"); 
            Assert.AreEqual(result, 205); 
        }
        [TestMethod] public void Returns_444() 
        { 
            int result = RomanNumValidator("CDXLIV"); 
            Assert.AreEqual(result, 444); 
        }
        [TestMethod] public void Returns_999() 
        { 
            int result = RomanNumValidator("CMXCIX"); 
            Assert.AreEqual(result, 999); 
        }
        [TestMethod] public void Returns_1000() 
        { 
            int result = RomanNumValidator("M"); 
            Assert.AreEqual(result, 1000); }
        [TestMethod] public void Returns_3888() 
        { 
            int result = RomanNumValidator("MMMDCCCLXXXVIII"); 
            Assert.AreEqual(result, 3888); 
        }
        [TestMethod] public void Returns_3910() 
        {
            int result = RomanNumValidator("MMMCMX"); 
            Assert.AreEqual(result, 3910); 
        }
        public static int RomanNumValidator(string num) 
        { 
            return RomanNumerals.ParseRomanNumeral(num); 
        } 
    } 
}