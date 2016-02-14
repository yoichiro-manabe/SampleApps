using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleApps.Controllers.Results;
using SampleApps.Models;

namespace SampleApps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SampleXml()
        {
            var samples = new SampleRoot();

            var sample1 = new Sample
            {
                Id = 1,
                Name = "サンプル1"
            };
            samples.Samples.Add(sample1);

            var sample2 = new Sample
            {
                Id = 2,
                Name = "サンプル2"
            };
            samples.Samples.Add(sample2);
            
            return new XmlResult(samples);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}