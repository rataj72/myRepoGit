using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FoXdb
{
    public class XMLParser
    {
        public List<string> columns = new List<string>();

        public Dictionary<int, List<string>> ParseToDictionaryList(XDocument xdoc)                          //todo obsłużyc zapytanie select *       !!!!
        {
            var dictionaryList = new Dictionary<int, List<string>>();

            foreach (var doc in xdoc.Descendants("Table"))
            {
                dictionaryList.Add(Int32.Parse((string)doc.Element("id")), null);         
                List<string> lista = new List<string>();

                for (int i = 0; i < columns.Count; i++)
                {
                    if (columns[i] != "id")
                    {
                        lista.Add((string)doc.Element(columns[i]));
                    }
                    dictionaryList[Int32.Parse((string)doc.Element("id"))] = lista;
                }
            }
            return dictionaryList;
        }

        public Dictionary<int, string> ParseToDictionaryString(XDocument xdoc)
        {
            var dictionaryText = new Dictionary<int, string>();

            foreach (var doc in xdoc.Descendants("Table"))
            {
                dictionaryText.Add(Int32.Parse((string)doc.Element("id")), null);           
                string tekst = "";

                for (int i = 0; i < columns.Count; i++)
                {
                    if (columns[i] != "id")
                    {
                        tekst += (string)doc.Element(columns[i]) + "_";
                    }
                    dictionaryText[Int32.Parse((string)doc.Element("id"))] = tekst;
                }
            }
            return dictionaryText;
        }
    }
}