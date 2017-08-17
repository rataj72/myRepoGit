using System;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeterWinformsApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1 : ShuffleMethod
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dictionary<string,int> dictionary=new Dictionary<string, int>();
            dictionary.Add("1",1);
            dictionary.Add("2",2);
            dictionary.Add("3",3);
            dictionary.Add("4",4);
            dictionary.Add("5",5);
            ShuffleMethod method = new ShuffleMethod();
            var sth = method.shuffle(dictionary, 10, 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            db db = new db();
            var dataset = db.getData("select * from ApplicationTest");
        }

        [TestMethod]
        public void TestMethodInsert()
        {
            ApplicationTestModel application = new ApplicationTestModel();
            DataStorageInsert insert = new DataStorageInsert();

            string command = insert.GetSetDataComand(application);

            //Assert.AreEqual(command , "insert into ApplicationTest (player, points) values ();");

            db db = new db();
            var dataset = db.getData(command);
        }
    }
}
