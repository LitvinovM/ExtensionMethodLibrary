using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VolumeInfo.Extension;

namespace VolumeInfoTest
{
    [TestClass]
    public class VolumeInfoConvertTest
    {
        [TestMethod]
        public void Convert_ByteToKByte_Amount()
        {
            // Arrange
            var excepted = 0.00098;

            // Act
            var actual = 1.Byte().ToKibibyte().Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_ByteToKByte_AmountByte()
        {
            // Arrange
            var excepted = 1;

            // Act
            var actual = 1.Byte().ToKibibyte().AmountByte;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_KByteToMByte_Amount()
        {
            // Arrange
            var excepted = 0.00098;

            // Act
            var actual = 1.Kibibyte().ToMebibyte().Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_KByteToMByte_AmountByte()
        {
            // Arrange
            var excepted = 1024;

            // Act
            var actual = 1.Kibibyte().ToMebibyte().AmountByte;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_TByteToMByte_Amount()
        {
            // Arrange
            var excepted = 1024 * 1024;

            // Act
            var actual = 1.Tebibyte().ToMebibyte().Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_TByteToMByte_AmountByte()
        {
            // Arrange
            var excepted = 1024L * 1024L * 1024L * 1024L;

            // Act
            var actual = 1.Tebibyte().ToMebibyte().AmountByte;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_ByteToKByteToMByteToGbyte_Amount()
        {
            // Arrange
            var excepted = 1;

            // Act
            var actual = (1024L * 1024L * 1024L).Byte().ToKibibyte().ToMebibyte().ToGibibyte().Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }

        [TestMethod]
        public void Convert_ByteToGbyte_Amount()
        {
            // Arrange
            var excepted = 1;

            // Act
            var actual = (1024L * 1024L * 1024L).Byte().ToGibibyte().Amount;

            // Assert
            Assert.AreEqual(excepted, actual, 0.0001);
        }
    }
}
