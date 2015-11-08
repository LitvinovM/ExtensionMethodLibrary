using System;
using System.Linq;
using System.Reflection;
using ExtensionMethodLibrary.Collection;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ExtensionMethodTest
{
    [TestClass]
    public class ExtensionCollectionTest
    {
        [TestMethod]
        public void integerTest()
        {
            //arrange
            var unit = Enumerable.Range(1, 10);
            //act
            unit.ForEach(z => Console.WriteLine(z));
            //assert
        }
    }
}
