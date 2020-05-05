using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Arrange
            List<int> myList = new List<int>() {1, 2, 3, 11};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void Test2()
        {
            // Arrange
            List<int> myList = new List<int>();
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(0, result);
        }
    }
}