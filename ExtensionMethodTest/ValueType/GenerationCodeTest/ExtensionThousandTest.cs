using System;
using ExtensionMethodLibrary.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType.GenerationCodeTest
{
    [TestClass]
    public class ExtensionThousandTest
    {

        [TestMethod]
        public void Thousand_Inteasdger_123()
        {
            // Arrange
            var value = 123;
            var excepted = value * 1000;
            
            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual);
        }


        [TestMethod]
        public void Thousand_Integer_123()
        {
            // Arrange
            var value = 123;
            var excepted = value * 1000;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Thousand_Integer_0()
        {
            // Arrange
            var value = 0;
            var excepted = value * 1000;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Thousand_Integer_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = value * 1000;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Thousand_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = value * 1000.0;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Thousand_Double_0()
        {
            // Arrange
            var value = 0.0;
            var excepted = value * 1000.0;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Thousand_Double_neg123()
        {
            // Arrange
            var value = -123.0;
            var excepted = value * 1000.0;

            // Act
            var actual = value.Thousand();

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
    }
}
