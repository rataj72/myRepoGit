using System.Xml.Serialization;

namespace XMLtakeingText.Logic
{
    [XmlRoot("transfers")]          //okresla kozen xmla -> tylko jedno wystapienie -> szuka w pliku
    public class TransferBase
    {
        [XmlElement("account")]
        public string Account { get; set; }


    }
}