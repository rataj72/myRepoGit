using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLtakeingText.Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            XMLParser<Transfers> transferParser = new XMLParser<Transfers>();
            var result  = transferParser.GetXmlData(
                @"C:\Users\Piotr\Desktop\myRepo\c#\zSzkolenia\XMLtakeingText\XMLtakeingText\XMLFile1.xml");

            var tab = result.TransfersList;

            var a = result.TransfersList[0].Account;
            var b = result.TransfersList[0].Bank;
            var c = result.TransfersList[0].Owner;
            var d = result.TransfersList[0].Sum;

        }
    }
}
