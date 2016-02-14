using System.Xml.Serialization;

namespace SampleApps.Models
{
    public class Sample
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlText]
        public string Name { get; set; }
    }
}