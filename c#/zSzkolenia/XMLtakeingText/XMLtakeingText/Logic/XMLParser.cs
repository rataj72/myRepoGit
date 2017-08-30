using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XMLtakeingText.Logic
{
    public class XMLParser<T>
    {
        public T GetXmlData(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            return (T)serializer.Deserialize(new StreamReader(path));

        }
    }
}