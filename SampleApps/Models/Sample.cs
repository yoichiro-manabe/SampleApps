using System.Xml.Serialization;

namespace SampleApps.Models
{
    public class Sample
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}