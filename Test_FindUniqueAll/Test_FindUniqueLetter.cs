using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUniqueLetter
{
    [TestClass]
    public class FindUniqueLetter
    {
        [TestMethod]
        public void Assert_OneLetter_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "F";
            string expectedtStr = "F";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneDigit_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "1";
            string expectedtStr = "";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoDigitLetter_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "1q";
            string expectedtStr = "q";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoLetterDigit_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "g1";
            string expectedtStr = "g";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_UnicLetters_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "qwerty";
            string expectedtStr = "qwerty";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicLetters_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "qwerttty";
            string expectedtStr = "qwert";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicLettersDigit_FindUniqueLetter()
        {
            // Arrange
            string inputStr = "123qwerttty";
            string expectedtStr = "qwert";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

    }
}