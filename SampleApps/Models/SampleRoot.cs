using System.Collections.Generic;
using System.Xml.Serialization;

namespace SampleApps.Models
{
    [XmlRoot(ElementName = "samples")]
    public class SampleRoot
    {
        [XmlElement("sample")]
        public List<Sample> Samples { get; set; } = new List<Sample>();
    }
}