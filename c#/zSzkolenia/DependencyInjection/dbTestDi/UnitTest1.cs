using System;
using DependencyInjection.dbNames;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dbTestDi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Client client = new Client();
            var a = client.MainToUse();
        }
    }
}
