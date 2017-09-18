using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGenerateFile()
        {
            FileGenerator f = new FileGenerator();

            for (int i = 0; i < 10; i++)
            {
                f.hipcio(null, i);
            }
        }

        [TestMethod]
        public void TestMethodGetPath()
        {
            FileReader f = new FileReader();

            var a = f.getPathList();
        }

        [TestMethod]
        public void TestMethodFileReader()
        {
            PeterFileReader f = new PeterFileReader();

            var getPathList = f.getPathList();

            var s1 = DateTime.Now.Millisecond;
            for (int i = 0; i < getPathList.Length; i++)
            {
                var getFileName = f.getFileName(getPathList[i]);
                var RunFactory = f.RunFactory(getFileName);
            }
            var e1 = DateTime.Now.Millisecond;


            var s2 = DateTime.Now.Millisecond;

            f.execute();

            var e2 = DateTime.Now.Millisecond;

            var a = PeterFileReader.licz;


            var q1 = e1 - s1;

            var q2 = e2 - s2;

        }
    }
}
