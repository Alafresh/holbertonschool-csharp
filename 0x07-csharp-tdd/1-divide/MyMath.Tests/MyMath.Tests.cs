using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            int[,] matrix = {
                {2, 6, 8},
                {10, 12, 14},
                {20, 30, 34}
                };
            int[,] expected = {
                {1, 3, 4},
                {5, 6, 7},
                {10, 15, 17}
            };

            // Act
            int [,] result = MyMath.Matrix.Divide(matrix, 2);

            // Assert
            Assert.AreEqual(expected, result);
        } 
        [Test]
        public void Test2()
        {
            int [,] result = MyMath.Matrix.Divide(null, 2);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void Test3()
        {
            int [,] matrix = {
                {2, 4},
                {6, 8}
            };
            int [,] result = MyMath.Matrix.Divide(matrix, 0);
            Assert.AreEqual(null, result);
        }
    }
}