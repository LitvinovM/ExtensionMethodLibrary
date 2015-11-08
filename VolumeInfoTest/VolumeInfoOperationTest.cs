using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VolumeInfo.Extension;

namespace VolumeInfoTest
{
    [TestClass]
    public class VolumeInfoOperationTest
    {
        #region addition
        [TestMethod]
        public void Operation_additionByteAndByte()
        {
            // Arrange
            var firstSummand = 1024.Byte();
            var secondSummand = 500.Byte();

            var excepted = 1024 + 500;

            // Act
            var actual = (firstSummand + secondSummand).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_additionMByteAndMByte()
        {
            // Arrange
            var firstSummand = 1024.Mebibyte();
            var secondSummand = 500.Mebibyte();

            var excepted = 1024 + 500;

            // Act
            var actual = (firstSummand + secondSummand).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_additionByteAndMByte()
        {
            // Arrange
            var firstSummand = 1024.Byte();
            var secondSummand = 500.Mebibyte();

            var excepted = 1024 + (500 * 1024 * 1024);

            // Act
            var actual = (firstSummand + secondSummand).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_additionMByteAndByte()
        {
            // Arrange
            var firstSummand = 1024.Mebibyte();
            var secondSummand = 500.Byte();

            var excepted = 1024.0 + ((500.0 / 1014.0) / 1024.0);

            // Act
            var actual = (firstSummand + secondSummand).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
        #endregion

        #region subtraction
        [TestMethod]
        public void Operation_subtractionByteAndByte()
        {
            // Arrange
            var firstSubtrahend = 1024.Byte();
            var secondSubtrahend = 500.Byte();

            var excepted = 1024 - 500;

            // Act
            var actual = (firstSubtrahend - secondSubtrahend).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_subtractionMByteAndMByte()
        {
            // Arrange
            var firstSubtrahend = 1024.Mebibyte();
            var secondSubtrahend = 500.Mebibyte();

            var excepted = 1024 - 500;

            // Act
            var actual = (firstSubtrahend - secondSubtrahend).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_subtractionByteAndMByte()
        {
            // Arrange
            var firstSubtrahend = 1024.Byte();
            var secondSubtrahend = 500.Mebibyte();

            var excepted = 1024 - (500 * 1024 * 1024);

            // Act
            var actual = (firstSubtrahend - secondSubtrahend).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_subtractionMByteAndByte()
        {
            // Arrange
            var firstSubtrahend = 1024.Mebibyte();
            var secondSubtrahend = 500.Byte();

            var excepted = 1024.0 - ((500.0 / 1014.0) / 1024.0);

            // Act
            var actual = (firstSubtrahend - secondSubtrahend).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
        #endregion

        #region multiplication

        [TestMethod]
        public void Operation_multiplicationByteOnInteger()
        {
            // Arrange
            var multiplier = 3;

            var excepted = 1 * multiplier;

            // Act
            var actual = (1.Byte() * multiplier).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_multiplicationByteOnDouble()
        {
            // Arrange
            var multiplier = 3.0;

            var excepted = 1 * multiplier;

            // Act
            var actual = (1.Byte() * multiplier).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_multiplicationMByteOnInteger()
        {
            // Arrange
            var multiplier = 3;

            var excepted = 1 * multiplier;

            // Act
            var actual = (1.Mebibyte() * multiplier).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_multiplicationMByteOnDouble()
        {
            // Arrange
            var multiplier = 3.0;

            var excepted = 1 * multiplier;

            // Act
            var actual = (1.Mebibyte() * multiplier).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        #endregion

        #region division

        [TestMethod]
        public void Operation_divisionByteOnInteger()
        {
            // Arrange
            var divider = 2;

            var excepted = 1.0 / divider;

            // Act
            var actual = (1.Byte() / divider).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_divisionByteOnDouble()
        {
            // Arrange
            var divider = 2.0;

            var excepted = 1 / divider;

            // Act
            var actual = (1.Byte() / divider).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_divisionMByteOnInteger()
        {
            // Arrange
            var divider = 2;

            var excepted = 1.0 / divider;

            // Act
            var actual = (1.Mebibyte() / divider).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Operation_divisionMByteOnDouble()
        {
            // Arrange
            var divider = 2.0;

            var excepted = 1 * divider;

            // Act
            var actual = (1.Mebibyte() * divider).Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        #endregion

        #region equality

        [TestMethod]
        public void Operation_equalityByteAndByte()
        {
            // Arrange
            var firstFalue = 123.Byte();
            var secondFalue = 123.Byte();

            // Act

            // Assert
            Assert.IsTrue(firstFalue == secondFalue);
        }

        [TestMethod]
        public void Operation_equalityByteAndKByte()
        {
            // Arrange
            var firstFalue = 2048.Byte();
            var secondFalue = 2.Kibibyte();

            // Act

            // Assert
            Assert.IsTrue(firstFalue == secondFalue);
        }

        [TestMethod]
        public void Operation_notEqualityByteAndKByte()
        {
            // Arrange
            var firstFalue = 2049.Byte();
            var secondFalue = 2.Kibibyte();

            // Act

            // Assert
            Assert.IsTrue(firstFalue != secondFalue);
        }

        #endregion
    }
}
