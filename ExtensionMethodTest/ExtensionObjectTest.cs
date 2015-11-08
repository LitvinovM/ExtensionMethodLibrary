using System;
using ExtensionMethodLibrary.Object;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethodTest
{
    [TestClass]
    public class ExtensionObjectTest
    {
        [TestMethod]
        public void ThrowExceptionIfNullMethodTest_1()
        {
            //arrange
            var someObject = new object();
            //act
            someObject.ThrowExceptionIfNull();
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowExceptionIfNullMethodTest_2()
        {
            //arrange
            Object someObject = null;
            //act
            someObject.ThrowExceptionIfNull();
            //assert
        }
    }
}
