using System.Collections.Generic;
using System.Xml.Serialization;

namespace SampleApps.Models
{
    [XmlRoot(ElementName = "samples")]
    public class SampleRoot
    {
        [XmlElement("sample")]
//        [XmlArray("sample")] // これは求めている物とは違う…
        public List<Sample> Samples { get; set; } = new List<Sample>();
    }
}