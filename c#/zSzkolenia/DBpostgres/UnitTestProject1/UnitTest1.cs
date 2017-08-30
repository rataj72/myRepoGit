using System;
using DBpostgres;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1          //monosecurity!!! 
    {
        [TestMethod]
        public void TestMethod1()
        {
            PostgreClient client = new PostgreClient("postgres","start12345","localhost","testowa");

            var result = client.GetData("select * from chmura");
            var result1 = client.GetData("insert into chmura(name) values ('z apki');");   
            
            // do zrobienia => wpompowanie tego z pliku txt :D  i wydzielenie przed nawias
        }
    }
}
