using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            string s = "level";

            // Act
            bool result = Text.Str.IsPalindrome(s);

            // Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test2()
        {
            // Arrange
            string s = "Racecar";

            // Act
            bool result = Text.Str.IsPalindrome(s);

            // Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test3()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Text.Str.IsPalindrome(s);

            // Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test4()
        {
            // Arrange
            string s = "";

            // Act
            bool result = Text.Str.IsPalindrome(s);

            // Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Test5()
        {
            // Arrange
            string s = "Brownies con helado";

            // Act
            bool result = Text.Str.IsPalindrome(s);

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}