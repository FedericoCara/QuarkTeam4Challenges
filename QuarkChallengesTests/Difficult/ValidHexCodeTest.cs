using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuarkTeam4Challenges.Difficult;
using System;

namespace QuarkChallengesTests {
    [TestClass] public class ValidHexCodeTest 
    {
        [TestMethod] 
        public void TheCodeIsCorrect() 
        {
            //Arrange
            string hasHashtagString = "#ABC123";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TheCodeHasntHashtagAtTheBeginning() {
            //Arrange
            string hasHashtagString = "ABC123";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void TheCodeHasntSixCharacters()
        {
            //Arrange
            string hasHashtagString = "#ABC12";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void HasANonAlphanumericCharacter()
        {
            //Arrange
            string hasHashtagString = "#ABC12,";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void HasALetterGreaterThanF() {
            //Arrange
            string hasHashtagString = "#FAh123";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsFalse(resultado);
        }


        [TestMethod]
        public void TheLettersAreBetweenAAndFAndContainsLowercase()
        {
            //Arrange
            string hasHashtagString = "#EaFd13";
            HexCode codigo = new HexCode();

            //Act
            bool resultado = codigo.IsValidHexCode(hasHashtagString);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Template() {
            //Arrange


            //Act

            //Assert

        }
    } 
}