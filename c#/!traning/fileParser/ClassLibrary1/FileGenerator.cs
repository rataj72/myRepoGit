using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace ClassLibrary1
{
    public class FileGenerator
    {
        public Dictionary<string, string> peopleNames = new Dictionary<string, string>                   //todo   uzupelniac to z pliku
        {
            {"jan","dobrowolski" },
            {"erley","filipek" },
            {"filik","kondziela" },
            {"dawid","zapart" },
            {"weronika","zywert" },
            {"kasia","adamek" },
            {"adam","kubon" },
        };

        public void makeFile(Stream stream, int liczba)
        {
            string path = String.Format(@"C:\Users\Piotr\Desktop\ClassLibrary1\ClassLibrary1\data\_doc{0}.txt",liczba);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
         }

        public void hipcio(Stream stream, int liczba)
        {
            string path = stream?.ToString() ?? String.Format(@"C:\Users\Piotr\Desktop\ClassLibrary1\ClassLibrary1\data\_doc{0}.txt", liczba);   //fajne -> to jest if

            /*foreach (var name in peopleNames)
            {
                peopleNames.Add(peopleNames[])
            }*/
            string tekst = "";

            foreach (var item in peopleNames)
            {
                tekst += String.Format("{0}/{1}/{2}+{3}", DateTime.Now, item.Key, item.Value, "\n");
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(tekst);
            }
        }
    }
}