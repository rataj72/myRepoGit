using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type[] allTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            var dane = XDocument.Load(@"C:\Users\piotr\Documents\Visual Studio 2017\Projects\zadanieXmlZc#\ConsoleApp2\tekstt\jeden.xml");

            foreach (var item in allTypesInAssembly)
            {
                var slowoX = item.ToString();
                               

                var tede = new XElement("item", new XText(slowoX), new XElement("tag", new XText("out = \"" + slowoX + "\";")));

                var customer = dane.Root.Elements("rule").Single(x => (string)x.Attribute("id") == "Accessor");

                customer.Element("one-of").Add(tede);

                
            }

            dane.Save("database.xml");
            


            ///////////////////////////////////////-----------------------------------------------------------

            //var cust = document.Element("");



            //var cust1 = document.Descendants("rule")
            //   .First(c => c.Attribute("id").Value == "0");

            //cust.Element("Accounts").Add(new XElement("Account", new XAttribute("id", "3")));

            Console.WriteLine(dane);
            

            Console.Read();
        }

        
    }
}
