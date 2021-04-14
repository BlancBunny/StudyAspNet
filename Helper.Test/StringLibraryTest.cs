using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Helper.Test
{
    [TestClass]
    public class StringLibraryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strCut = "Hello World, This is a test sentence";
            int intChar = 15;

            var expected = "Hello World,...";
            var actual = StringLibrary.CutString(strCut, intChar);
            Assert.AreEqual(expected, actual);
        }
    }
}
