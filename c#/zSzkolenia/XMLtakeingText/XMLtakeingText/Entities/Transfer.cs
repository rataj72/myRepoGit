using System.Xml.Serialization;

namespace XMLtakeingText.Logic
{
    [XmlRoot("transfer")] //XmlArray,  XmlNodeList
    public class Transfer :TransferBase
    {
        //[XmlElement("account")]
        //public string Account { get; set; }               // atrybuty sie dziedzicza

        [XmlAttribute("bank")]
        public string Bank { get; set; }

        [XmlElement("owner")]
        public string Owner { get; set; }

        [XmlElement("sum")]
        public string Sum { get; set; }

    }

    [XmlRoot("transfers")]
    public class Transfers
    {
        [XmlElement("transfer")]
        public Transfer[] TransfersList { get; set; }
    }
}