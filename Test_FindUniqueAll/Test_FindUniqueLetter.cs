using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUniqueLetter
{
    /// <summary>
    /// Class Assert FindUniqueLetter without DataRow  
    /// </summary>
    [TestClass]
    public class FindUniqueLetter
    {
        Unique unicLine = new Unique();

        [TestMethod]
        public void Assert_EmptyInput_ReturnEmpty()
        {
            // Arrange
            string inputStr = "";
            string expectedtStr = "";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneLetter_ReturnOneLetter()
        {
            // Arrange
            string inputStr = "F";
            string expectedtStr = "F";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneDigit_ReturnEmpty()
        {
            // Arrange
            string inputStr = "1";
            string expectedtStr = "";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoDigitLetter_ReturnOneLetter()
        {
            // Arrange
            string inputStr = "1q";
            string expectedtStr = "q";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoLetterDigit_ReturnOneLetter()
        {
            // Arrange
            string inputStr = "g1";
            string expectedtStr = "g";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_UnicLetters_ReturnAllLetters()
        {
            // Arrange
            string inputStr = "qwerty";
            string expectedtStr = "qwerty";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicLetters_ReturnUniqueLetter()
        {
            // Arrange
            string inputStr = "qwerttty";
            string expectedtStr = "qwert";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicLettersDigit_ReturnUniqueLetter()
        {
            // Arrange
            string inputStr = "123qwerttty";
            string expectedtStr = "qwert";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_RepetesLetters_ReturnOneLetter()
        {
            // Arrange
            string inputStr = "ttttttt";
            string expectedtStr = "t";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoNonUnicLettersDigit_ReturnLongUniqueLetter()
        {
            // Arrange
            string inputStr = "123qwertttyewsds";
            string expectedtStr = "tyewsds";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoNonUnicLettersDigitBreak_ReturnLongUniqueLetter()
        {
            // Arrange
            string inputStr = "123qwer4567asdfg";
            string expectedtStr = "asdfg";

            // Act
            string resultStr = unicLine.FindUniqueLetter(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

    }
}