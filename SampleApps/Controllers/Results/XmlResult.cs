using System.Web.Mvc;
using System.Xml.Serialization;

namespace SampleApps.Controllers.Results
{
    public class XmlResult : ActionResult
    {
        public XmlResult(object objectToSerialize)
        {
            ObjectToSerialize = objectToSerialize;
        }

        public object ObjectToSerialize { get; }

        public override void ExecuteResult(ControllerContext context)
        {
            if (ObjectToSerialize != null)
            {
                context.HttpContext.Response.Clear();
                var xs = new XmlSerializer(ObjectToSerialize.GetType());
                context.HttpContext.Response.ContentType = "text/xml";

                var xmlnsEmpty = new XmlSerializerNamespaces();
                xmlnsEmpty.Add("", "");
                xs.Serialize(context.HttpContext.Response.Output, ObjectToSerialize, xmlnsEmpty);
            }
        }
    }
}