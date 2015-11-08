using System;
using ExtensionMethodLibrary.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType.GenerationCodeTest
{
    [TestClass]
    public class ExtensionMillionTest
    {
        [TestMethod]
        public void Million_Integer_123()
        {
            // Arrange
            var value = 123;
            var excepted = value * 1000 * 1000;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Million_Integer_0()
        {
            // Arrange
            var value = 0;
            var excepted = value * 1000 * 1000;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Million_Integer_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = value * 1000 * 1000;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Million_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = value * 1000.0 * 1000.0;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Million_Double_0()
        {
            // Arrange
            var value = 0.0;
            var excepted = value * 1000.0 * 1000.0;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Million_Double_neg123()
        {
            // Arrange
            var value = -123.0;
            var excepted = value * 1000.0 * 1000.0;

            // Act
            var actual = value.Million();


            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
    }
}
