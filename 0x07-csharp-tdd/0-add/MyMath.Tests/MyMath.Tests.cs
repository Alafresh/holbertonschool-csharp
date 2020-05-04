using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int expected = 5;

            // Act
            int result = MyMath.Operations.Add(2, 3);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}