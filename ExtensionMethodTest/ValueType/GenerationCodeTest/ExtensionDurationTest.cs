using System;
using ExtensionMethodLibrary.ValueTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType.GenerationCodeTest
{
    [TestClass]
    public class ExtensionDurationTest
    {
        [TestMethod]
        public void Day_Integer_123()
        {
            // Arrange
            var value = 123;
            var excepted = new TimeSpan(value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Day_Integer_0()
        {
            // Arrange
            var value = 0;
            var excepted = new TimeSpan(value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Day_Integer_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = new TimeSpan(value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Day_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = new TimeSpan((int)value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Day_Double_0()
        {
            // Arrange
            var value = 0.0;
            var excepted = new TimeSpan((int)value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Day_Double_neg123()
        {
            // Arrange
            var value = -123.0;
            var excepted = new TimeSpan((int)value, 0, 0, 0);

            // Act
            var actual = value.Day();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Integer_123()
        {
            // Arrange
            var value = 123;
            var excepted = new TimeSpan(0, 0, 0, value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Integer_0()
        {
            // Arrange
            var value = 0;
            var excepted = new TimeSpan(0, 0, 0, value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Integer_neg123()
        {
            // Arrange
            var value = -123;
            var excepted = new TimeSpan(0, 0, 0, value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Double_123()
        {
            // Arrange
            var value = 123.0;
            var excepted = new TimeSpan(0, 0, 0, (int)value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Double_0()
        {
            // Arrange
            var value = 0.0;
            var excepted = new TimeSpan(0, 0, 0, (int)value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Second_Double_neg123()
        {
            // Arrange
            var value = -123.0;
            var excepted = new TimeSpan(0, 0, 0, (int)value);

            // Act
            var actual = value.Second();

            // Assert
            Assert.AreEqual(excepted, actual);
        }
    }
}
