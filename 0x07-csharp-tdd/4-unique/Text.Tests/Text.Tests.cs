using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string s = "aabbcddee";
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
        [Test]
        public void Test3()
        {
            // Arrange
            string s = "abbccdd";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test4()
        {
            // Arrange
            string s = "aabbccdde";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(8, result);
        }
         public void Test4()
        {
            // Arrange
            string s = "a";
            // Act
            int result = Text.Str.UniqueChar(s);
            // Assert
            Assert.AreEqual(0, result);
        }
    }
}