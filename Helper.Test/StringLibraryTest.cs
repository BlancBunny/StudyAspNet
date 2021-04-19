using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Helper.Test
{
    [TestClass]
    public class StringLibraryTest
    {
        [Ignore]
        [TestMethod]
        public void TestMethod1()
        {
            string strCut = "Hello World, This is a test sentence";
            int intChar = 15;

            var expected = "Hello World,...";
            var actual = StringLibrary.CutString(strCut, intChar);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPhotoTest()
        {
            var imagePath = @"C:\Users\PKNU\Downloads\no_picture.jpg";
            bool result = BoardLibrary.IsPhoto(imagePath);
            Assert.IsTrue(result, "File Extension must be png, jpg, gif");
        }

        [TestMethod]
        public void IsPhotoTest2()
        {
            var imagePath = @"‪C:\Users\PKNU\Downloads\naver.ico";
            bool result = BoardLibrary.IsPhoto(imagePath);
            Assert.IsFalse(result, "File Extension must be png, jpg, gif");
        }

    }
}
