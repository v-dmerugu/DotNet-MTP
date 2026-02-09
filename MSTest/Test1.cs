using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public sealed class Test1
    {
        // ✅ Basic equality test (your original test)
        [TestMethod]
        public void AreEqual_ShouldPass_WhenValuesAreSame()
        {
            // Arrange
            int expected = 1;
            int actual = 1;

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        // ✅ Boolean condition test
        [TestMethod]
        public void IsTrue_ShouldPass_WhenConditionIsTrue()
        {
            // Arrange
            bool condition = (5 > 3);

            // Act & Assert
            Assert.IsTrue(condition);
        }

        // ✅ String comparison test
        [TestMethod]
        public void AreEqual_ShouldPass_ForSameStrings()
        {
            // Arrange
            string expected = "Hello";
            string actual = "Hello";

            // Act & Assert
            Assert.AreEqual(expected, actual);
        }

        // ✅ Collection count test
        [TestMethod]
        public void Collection_ShouldHaveExpectedCount()
        {
            // Arrange
            var numbers = new List<int> { 1, 2, 3 };

            // Act
            int count = numbers.Count;

            // Assert
            Assert.AreEqual(3, count);
        }

    }
}
