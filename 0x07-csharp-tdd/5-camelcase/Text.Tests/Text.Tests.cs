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
        public void Test2()
        {
            // Arrange
            string s = "";
            // Act
            int result = Text.Str.CamelCase(s);
            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Test3()
        {
            // Arrange
            string s = "juan";
            // Act
            int result = Text.Str.CamelCase(s);
            // Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Test4()
        {
            // Arrange
            string s = "ALELUYA";
            // Act
            int result = Text.Str.CamelCase(s);
            // Assert
            Assert.AreEqual(6, result);
        }
    }
}