using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUniqueDigit
{
    [TestClass]
    public class FindUniqueDigit
    {
        [TestMethod]
        public void Assert_EmptyInput_ReturnEmpty()
        {
            // Arrange
            string inputStr = "";
            string expectedtStr = "";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneDigit_ReturnOneDigit()
        {
            // Arrange
            string inputStr = "8";
            string expectedtStr = "8";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneLetter_ReturnEmpty()
        {
            // Arrange
            string inputStr = "L";
            string expectedtStr = "";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoDigitLetter_ReturnOneDigit()
        {
            // Arrange
            string inputStr = "6q";
            string expectedtStr = "6";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoLetterDigit_ReturnOneDigit()
        {
            // Arrange
            string inputStr = "g9";
            string expectedtStr = "9";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_UnicDigits_ReturnAllDigits()
        {
            // Arrange
            string inputStr = "123987";
            string expectedtStr = "123987";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicDigits_ReturnUniqueDigit()
        {
            // Arrange
            string inputStr = "1234555567";
            string expectedtStr = "12345";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicDigitLetter_ReturnUniqueDigit()
        {
            // Arrange
            string inputStr = "123qwerttty";
            string expectedtStr = "123";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_RepetesDigits_ReturnOneDigit()
        {
            // Arrange
            string inputStr = "777777";
            string expectedtStr = "7";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoNonUnicLettersDigits_ReturnLongUniqueDigit()
        {
            // Arrange
            string inputStr = "123456wer12367ttyewsds";
            string expectedtStr = "123456";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoNonUnicDigitsDigitBreak_ReturnLongUniqueDigit()
        {
            // Arrange
            string inputStr = "12113qwer4567asdfg";
            string expectedtStr = "4567";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

    }
}