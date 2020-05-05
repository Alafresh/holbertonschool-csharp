using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string s = "aabbcdd";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(4, result);
        }
        [Test]
        public void Test2()
        {
            // Arrange
            string s = "";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(-1, result);
        }
        /*[Test]
        public void Test3()
        {
            // Arrange
            string s = "Lalbcd";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(1, result);
        }*/
    }
}