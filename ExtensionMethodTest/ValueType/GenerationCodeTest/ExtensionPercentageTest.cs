using System;
using ExtensionMethodLibrary.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType.GenerationCodeTest
{
    [TestClass]
    public class ExtensionPercentageTest
    {
        [TestMethod]
        public void Percentage_Inteasdger_123()
        {
            // Arrange
            var value = 123;
            var excepted = value * 0.1;
            
            // Act
            var actual = value.Percentage(10);

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Percentage_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = value * 0.2;

            // Act
            var actual = value.Percentage(20);

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Percentage_Decimal_123()
        {
            // Arrange
            var value = 123M;
            var excepted = value * 0.25M;

            // Act
            var actual = value.Percentage(25);

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Percentage_Inteasdger_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = value * 0.1;

            // Act
            var actual = value.Percentage(10);

            // Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
