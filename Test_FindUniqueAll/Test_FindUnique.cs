using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUnique
{
    [TestClass]
    public class FindUnique
    {
        [TestMethod]
        public void Assert_EmptyInput_ReturnEmpty()
        {
            // Arrange
            string inputStr = "";
            string expectedtStr = "";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_OneChar_ReturnOneChar()
        {
            // Arrange
            string inputStr = "F";
            string expectedtStr = "F";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_TwoUniqueChar_ReturnTwoChar()
        {
            // Arrange
            string inputStr = "1q";
            string expectedtStr = "1q";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_NonUnicLetters_ReturnUniqueChars()
        {
            // Arrange
            string inputStr = "qwerttty";
            string expectedtStr = "qwert";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_LettersDigit_ReturnUniqueChars()
        {
            // Arrange
            string inputStr = "123qwerttty";
            string expectedtStr = "123qwert";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_RepetesLetters_ReturnOneChar()
        {
            // Arrange
            string inputStr = "aaaaaaaa";
            string expectedtStr = "a";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_LongUnicDigitLetters_ReturnAllLongUnique()
        {
            // Arrange
            string inputStr = "123qwer4567asdfg";
            string expectedtStr = "123qwer4567asdfg";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_LongNonUnicTwoPart_ReturnFirstLongUnique()
        {
            // Arrange
            string inputStr = "123qwertyy4asdfg";
            string expectedtStr = "123qwerty";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }

        [TestMethod]
        public void Assert_LongNonUnicTwoPart_ReturnSecongLongUnique()
        {
            // Arrange
            string inputStr = "123qwertyy1123456789qwe123";
            string expectedtStr = "123456789qwe123";
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUnique(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }
    }
}
