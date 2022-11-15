using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpamCharProject;

namespace Test_FindUnique
{
    [TestClass]
    public class FindUnique
    {
        [TestMethod]
        public void Assert_OneChar_FindUnique()
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


    }
}
