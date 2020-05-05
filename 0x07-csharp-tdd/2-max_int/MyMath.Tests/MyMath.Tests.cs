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
            List<int> myList = new List<int>() {1, 2, 11, 3, 4};
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
         [Test]
        public void Test3()
        {
            // Arrange
            List<int> myList = new List<int>() {11, 2, 1, 3, 4};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(11, result);
        }
         [Test]
        public void Test4()
        {
            // Arrange
            List<int> myList = new List<int>() {1, 2, 4, 3, 11};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(11, result);
        }
         [Test]
        public void Test5()
        {
            // Arrange
            List<int> myList = new List<int>() {-1, -2, -11, -3, -4};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(-1, result);
        }
         [Test]
        public void Test6()
        {
            // Arrange
            List<int> myList = new List<int>() {2};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(2, result);
        }
         [Test]
        public void Test7()
        {
            // Arrange
            List<int> myList = new List<int>() {1, 2, -11, 3, 4};
            // Act
            int result = MyMath.Operations.Max(myList);
            // Assert
            Assert.AreEqual(4, result);
        }
    }
}