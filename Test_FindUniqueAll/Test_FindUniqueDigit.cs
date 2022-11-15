using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUniqueDigit
{
    /// <summary>
    /// Class Assert FindUniqueDigit with DataRow 
    /// </summary>
    [TestClass]
    public class FindUniqueDigit
    {
        [TestMethod]
        [DataRow("","")]
        [DataRow("8","8")]
        [DataRow("L","")]
        [DataRow("6q","6")]
        [DataRow("g5","5")]
        [DataRow("777777", "7")]
        [DataRow("123987", "123987")]
        [DataRow("1234555567", "12345")]
        [DataRow("123qwerttty", "123")]
        [DataRow("12113qwer4567asdfg", "4567")]
        [DataRow("123456wer12367ttyewsds", "123456")]
        public void Assert_EmptyInput_ReturnEmpty(string input, string result)
        {
            // Arrange
            string inputStr = input;
            string expectedtStr = result;
            Unique unicLine = new Unique();

            // Act
            string resultStr = unicLine.FindUniqueDigit(inputStr);

            // Assert
            Assert.AreEqual(expectedtStr, resultStr);
        }
    }
}