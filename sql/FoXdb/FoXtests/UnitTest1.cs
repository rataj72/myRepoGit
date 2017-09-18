using System;
using FoXdb;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoXtests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SelectTestMethod()
        {
            PostgreClient client = new PostgreClient("postgres", "start12345", "localhost", "5432", "FoX");

            var select = client.Select("users", "id,name,number");
        }

        [TestMethod]
        public void InsertTestMethod()
        {
            PostgreClient client = new PostgreClient("postgres", "start12345", "localhost", "5432", "FoX");

            for (int i = 0; i < 10; i++)
            {
                client.Insert("users","name,number","git,33");
            }
        }

        [TestMethod]
        public void DeleteTestMethod()
        {
            PostgreClient client = new PostgreClient("postgres", "start12345", "localhost", "5432", "FoX");

            client.Delete("users","id","1");
        }

        [TestMethod]
        public void UpdateTestMethod()
        {
            PostgreClient client = new PostgreClient("postgres", "start12345", "localhost", "5432", "FoX");

            client.Update("users","name","HENIO","id","5");
        }

    }
}
