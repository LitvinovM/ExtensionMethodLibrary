using System;
using System.IO;
using ExtensionMethodLibrary.ReferenceTypes.Serialization;
using ExtensionMethodLibrary.ReferenceTypes.StreamMemory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest.ReferenceTypes.Serialization
{
    [TestClass]
    public class ExtensionSerializationTest
    {
        [TestMethod]
        public void Serialization_ToXml()
        {
            // Arrange
            var someObject = new TestSerializationObject() { NumbericProperty = 1000, StringProperty = "test" };

            // Act
            var stream = someObject.ToXml();

            var desirializeObject = stream.FromXml<TestSerializationObject>();

            stream.Close();

            // Assert
            Assert.AreEqual(someObject.NumbericProperty, desirializeObject.NumbericProperty);
            Assert.AreEqual(someObject.StringProperty, desirializeObject.StringProperty);
        }

        [TestMethod]
        public void Serialization_ToBinary()
        {
            // Arrange
            var someObject = new TestSerializationObject() { NumbericProperty = 1000, StringProperty = "test" };

            // Act
            var stream = someObject.ToBinary();

            var desirializeObject = stream.FromBinary<TestSerializationObject>();

            stream.Close();

            // Assert
            Assert.AreEqual(someObject.NumbericProperty, desirializeObject.NumbericProperty);
            Assert.AreEqual(someObject.StringProperty, desirializeObject.StringProperty);
        }

        [TestMethod]
        public void Serialization_ToBinarySave()
        {
            // Arrange
            var path = new FileInfo("test.xml");
            var someObject = new TestSerializationObject { NumbericProperty = 1000, StringProperty = "test" };

            // Act
            someObject.ToBinary().Save(path);
            var desirializeObject = path.Read().FromBinary<TestSerializationObject>();

            // Assert
            Assert.AreEqual(someObject.NumbericProperty, desirializeObject.NumbericProperty);
            Assert.AreEqual(someObject.StringProperty, desirializeObject.StringProperty);
        }

        [TestMethod]
        public void Serialization_ToXmlSave()
        {
            // Arrange
            var path = new FileInfo("test.xml");
            var someObject = new TestSerializationObject { NumbericProperty = 1000, StringProperty = "test" };

            // Act
            someObject.ToXml().Save(path);
            var desirializeObject = path.Read().FromXml<TestSerializationObject>();

            // Assert
            Assert.AreEqual(someObject.NumbericProperty, desirializeObject.NumbericProperty);
            Assert.AreEqual(someObject.StringProperty, desirializeObject.StringProperty);
        }
    }

    [Serializable]
    public class TestSerializationObject
    {
        public int NumbericProperty { get; set; }

        public string StringProperty { get; set; }
    }
}
