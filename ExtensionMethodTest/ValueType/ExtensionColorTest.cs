using System;
using System.Diagnostics;
using System.Drawing;
using ExtensionMethodLibrary.ValueTypes.ColorExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType
{
    [TestClass]
    public class ExtensionColorTest
    {
        [TestMethod]
        public void Darken_BLack_Test()
        {
            // Arrange
            var color = Color.White;

            // Act
            var black = color.Darken(100.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(Color.Black, black));
        }

        [TestMethod]
        public void Lighten_White_Test()
        {
            // Arrange
            var color = Color.Black;

            // Act
            var white = color.Lighten(100.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(Color.White, white));
        }

        [TestMethod]
        public void Lighten_Half_Test()
        {
            // Arrange
            var color = Color.Black;
            var expectedColor = Color.FromArgb(255, 255 / 2, 255 / 2, 255 / 2);

            // Act
            var actual = color.Lighten(50.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(expectedColor, actual));
        }

        [TestMethod]
        public void Darken_Half_Test()
        {
            // Arrange
            var color = Color.White;
            var expectedColor = Color.FromArgb(255, 255 / 2, 255 / 2, 255 / 2);

            // Act
            var actual = color.Darken(50.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(expectedColor, actual));
        }

        [TestMethod]
        public void Darken_Quarter_Test()
        {
            // Arrange
            var color = Color.White;
            var expectedColor = Color.FromArgb(255, 254 - 255 / 4, 254 - 255 / 4, 254 - 255 / 4);

            // Act
            var actual = color.Darken(25.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(expectedColor, actual));
        }

        [TestMethod]
        public void Lighten_Quarter_Test()
        {
            // Arrange
            var color = Color.Black;
            var expectedColor = Color.FromArgb(255, 255 / 4, 255 / 4, 255 / 4);

            // Act
            var actual = color.Lighten(25.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(expectedColor, actual));
        }


        [TestMethod]
        public void Lighten_MoreThanMaximum_Test()
        {
            // Arrange
            var color = Color.White;

            // Act
            var actual = color.Lighten(50.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(Color.White, actual));
        }

        [TestMethod]
        public void Darken_MoreThanMaximum_Test()
        {
            // Arrange
            var color = Color.Black;

            // Act
            var actual = color.Darken(50.0);

            // Assert
            Assert.IsTrue(SimpleCompareColor(Color.Black, actual));
        }

        private bool SimpleCompareColor(Color first, Color second)
        {
            return first.A == second.A 
                && first.R == second.R 
                && first.G == second.G 
                && first.B == second.B;
        }
    }
}
