using System;
using fabryka;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            RightPostCodeValidator test = new RightPostCodeValidator();

            Assert.IsTrue(test.IsCodeValid(Province.Slaskie, "50-013"));
        }
    }
}
