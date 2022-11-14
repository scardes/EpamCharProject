using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUniqueLetter
{
    [TestClass]
    public class FindUniqueLetter
    {
        [TestMethod]
        public void Check_WithOneChar_FindUniqueLetter()
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
        public void Check_WithOneDigit_FindUniqueLetter()
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

    }
}