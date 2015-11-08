using System;
using ExtensionMethodLibrary.ValueTypes.Date;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ValueType
{
    [TestClass]
    public class ExtensionDateTest
    {
        [TestMethod]
        public void FutureTest()
        {
            // Arrange
            var timeSpanValue = TimeSpan.FromDays(123);
            var excepted = DateTime.Now.Add(timeSpanValue);

            // Act
            var actual = timeSpanValue.Future();

            // Assert
            Assert.AreEqual(excepted.Date, actual.Date);
        }

        [TestMethod]
        public void AgoTest()
        {
            // Arrange
            var timeSpanValue = TimeSpan.FromDays(123);
            var excepted = DateTime.Now.Subtract(timeSpanValue);

            // Act
            var actual = timeSpanValue.Ago();

            // Assert
            Assert.AreEqual(excepted.Date, actual.Date);
        }
    }
}
