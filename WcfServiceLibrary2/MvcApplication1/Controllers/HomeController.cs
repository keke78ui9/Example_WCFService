using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.ServiceModel;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MvcCall.Service1Client data = new MvcCall.Service1Client();
            data.Endpoint.Address = 
                new EndpointAddress("http://localhost:8732/Design_Time_Addresses/WcfServiceLibrary1/Service1/");
            data.ClientCredentials.Windows.ClientCredential = 
                CredentialCache.DefaultNetworkCredentials;
            ViewBag.Message = data.GetData(10);
            
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
