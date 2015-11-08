using System;
using ExtensionMethodLibrary.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType.GenerationCodeTest
{
    [TestClass]
    public class ExtensionHundredTest
    {
        [TestMethod]
        public void Hundred_Integer_123()
        {
            // Arrange
            var value = 123;
            var excepted = value * 100;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Hundred_Integer_0()
        {
            // Arrange
            var value = 0;
            var excepted = value * 100;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Hundred_Integer_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = value * 100;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Hundred_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = value * 100.0;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Hundred_Double_0()
        {
            // Arrange
            var value = 0.0;
            var excepted = value * 100.0;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Hundred_Double_neg123()
        {
            // Arrange
            var value = -123.0;
            var excepted = value * 100.0;

            // Act
            var actual = value.Hundred();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
    }
}
