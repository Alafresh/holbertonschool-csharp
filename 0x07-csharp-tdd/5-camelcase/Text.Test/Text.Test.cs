using NUnit.Framework;

namespace Text.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string s = "juanCaicedo";
            // Act
            int result = Text.Str.CamelCase(s);
            // Assert
            Assert.AreEqual(2, result);
        }
        [Test]
        public void Test()
        {
            // Arrange
            string s = "";
            // Act
            int result = Text.Str.CamelCase(s);
            // Assert
            Assert.AreEqual(0, result);
        }
    }
}